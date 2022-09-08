namespace State;

/**
 * A simple note that can be published.
 *
 * This is the "Context", it has 3 states: draft, in review, and published
 *
 * This is the object that outside things interact with -
 * it delegates state-specific calls to the state object
 */
public class Note
{
    public string Name { get; }

    /**
     * The current state object
     * it has an non-private set so that the state
     * objects can control when it changes state
     */
    internal NoteState State { private get; set; }

    public Note(string name)
    {
        /*
         * defaults to "draft" state
         */
        Name = name;
        State = new DraftState(this);
    }

    public string Status => State.Status;

    #region state-specific behavior
    public string GetContent()
    {
        return State.GetContent();
    }

    public void Review(bool approve)
    {
        State.Review(approve);
    }

    public void Publish()
    {
        State.Publish();
    }

    public void UpdateContent(string content)
    {
        State.UpdateContent(content);
    }

    #endregion
}