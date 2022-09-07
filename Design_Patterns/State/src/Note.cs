namespace State;

public class Note
{
    public string Name { get; }
    internal NoteState State { private get; set; }

    public Note(string name)
    {
        Name = name;
        State = new DraftState(this);
    }

    public string Status => State.Status;

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
}