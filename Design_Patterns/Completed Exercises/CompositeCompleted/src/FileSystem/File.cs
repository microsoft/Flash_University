namespace Composite.FileSystem;

/**
 * A File containing text content
 */
public class File : Item
{
    public File(string name, Item? parent, string content) : base(name, parent)
    {
        Content = content;
    }

    public string Content { get; }

    #region Item Implementation

    public override string DisplayName => Name;
    public override int SizeOnDisk => Content.Length;

    public override void Add(Item item)
    {
        // do nothing!
    }

    public override void Remove(string name)
    {
        // do nothing!
    }

    public override Dictionary<string, Item> GetChildren()
    {
        // doesn't make sense for files
        return new Dictionary<string, Item>();
    }

    public override Item? GetChild(string name)
    {
        // doesn't make sense for files
        return null;
    }
    
    #endregion
}