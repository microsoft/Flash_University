namespace State;

/**
 * The note state base class
 *
 * This is the "Abstract State Superclass"
 *
 * It abstracts out some common properties and
 * has abstract methods for all the state-specific methods
 */
internal abstract class NoteState
{
    protected Note Note { get; }
    public string Status { get; }
    
    /**
     * The note's content
     *
     * Since this field is not state-specific, we could move it to
     * the Note class & everything would still work
     */
    protected string Content;

    /*
     * This constructor is only for constructing the initial state
     * since the Content is set to "".
     *
     * Only the DraftState calls this constructor (since the
     * DraftState is the only viable initial state)
     */
    internal NoteState(Note note, string status)
    {
        Note = note;
        Content = "";
        Status = status;
    }

    /*
     * This constructor is helpful when transitioning between states.
     * You can pass in the existing state, and all the properties
     * will be copied over (eg the Content won't be lost)
     */
    internal NoteState(NoteState state, string status)
    {
        Note = state.Note;
        Content = state.Content;
        Status = status;
    }


    #region abstract methods

    public abstract string GetContent();
    public abstract void Review(bool approve);
    public abstract void Publish();
    public abstract void UpdateContent(string content);

    #endregion
}

/**
 * The "draft" specific state/behavior
 *
 * This represents a note that is still being written (hence "draft")
 *
 * This is the initial state of a note - hence it
 * has a constructor for the initial state.
 *
 * "draft" state behavior:
 * - UpdateContent: the note's content can be updated freely
 * - GetContent: the note's content is prefixed with "DRAFT"
 * - Review: does nothing
 *      (you can review a draft note, but that doesn't take it out of draft state)
 * - Publish: transitions to the "review" state
 */
internal class DraftState : NoteState
{
    /**
     * constructor for the initial state
     */
    internal DraftState(Note note) : base(note, "draft")
    {
    }

    /**
     * constructor for transitioning between states
     */
    internal DraftState(NoteState state) : base(state, "draft")
    {
    }

    #region NoteState methods

    public override string GetContent()
    {
        return $"--- DRAFT ---\n[{Note.Name}]\n\n{Content}";
    }

    public override void Review(bool approve)
    {
    }

    public override void Publish()
    {
        Note.State = new ReviewState(this);
    }

    public override void UpdateContent(string content)
    {
        Content = content;
    }

    #endregion
}

/**
 * The "in review" specific state/behavior
 *
 * This represents a note that has been requested to be published.
 * Depending on the outcome of the review, it will move to "draft" or "published" state.
 *
 * "review" state behavior:
 * - UpdateContent: the note's content can be updated, but this will transition it back to "draft" state
 * - GetContent: the note's content includes "(under review)"
 * - Review:
 *      if approved, transitions to "published"
 *      if not approved, transitions back to "draft"
 * - Publish: does nothing (note has already been requested to be published)
 */
internal class ReviewState : NoteState
{
    internal ReviewState(NoteState state) : base(state, "review")
    {
    }

    #region NoteState methods

    public override string GetContent()
    {
        return $"[{Note.Name}] (under review)\n\n{Content}";
    }

    public override void Review(bool approve)
    {
        if (approve)
            Note.State = new PublishedState(this, DateTime.Now);
        else
            Note.State = new DraftState(this);
    }

    public override void Publish()
    {
    }

    public override void UpdateContent(string content)
    {
        Content = content;
        Note.State = new DraftState(this);
    }

    #endregion
}

/**
 * The "in review" specific state/behavior
 *
 * This represents a note that has been published.
 * Once published, a note cannot be updated or unpublished (it is permanent)
 *
 * "published" state behavior:
 * - UpdateContent: throws an exception (publishing is permanent)
 * - GetContent: the note's content includes "(reviewed at: XXXX)"
 * - Review: throws an exception (publishing is permanent)
 * - Publish: does nothing (note has already been published)
 */
internal class PublishedState : NoteState
{
    /**
     * The date/time the note was reviewed
     *
     * This field is specific to the Published state
     * (contrast to Content which pertains to all states)
     */
    public DateTime ReviewedAt { get; }

    internal PublishedState(NoteState state, DateTime reviewedAt) : base(state, "published")
    {
        ReviewedAt = reviewedAt;
    }

    #region NoteState methods

    public override string GetContent()
    {
        return $"[{Note.Name}]\n\n{Content}\n\n(reviewed at: {ReviewedAt:g})";
    }

    public override void Review(bool approve)
    {
        throw new Exception("cannot re-review a published note");
    }

    public override void Publish()
    {
    }

    public override void UpdateContent(string content)
    {
        throw new Exception("cannot update a published note");
    }

    #endregion
}