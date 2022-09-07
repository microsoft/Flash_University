namespace State;

internal abstract class NoteState
{
    protected Note Note { get; }
    protected string Content;
    public string Status { get; }

    internal NoteState(Note note, string status)
    {
        Note = note;
        Content = "";
        Status = status;
    }

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

internal class DraftState : NoteState
{
    internal DraftState(Note note) : base(note, "draft")
    {
    }

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

internal class PublishedState : NoteState
{
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