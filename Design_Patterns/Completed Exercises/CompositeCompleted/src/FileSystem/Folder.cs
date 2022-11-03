namespace Composite.FileSystem;

/**
 * A Folder containing other folders or files.
 */
public class Folder : Item
{
    public Folder(string name, Item? parent) : base(name, parent)
    {
        _children = new Dictionary<string, Item>();
    }

    private readonly Dictionary<string, Item> _children;

    #region Item Implmentation

    public override string DisplayName => Name + "/";

    public override int SizeOnDisk
    {
        get
        {
            var size = 0;

            foreach (var child in _children)
            {
                size += child.Value.SizeOnDisk;
            }

            return size;
        }
    }

    public override void Add(Item item)
    {
        _children.Add(item.Name, item);
    }

    public override void Remove(string name)
    {
        _children.Remove(name);
    }

    public override Dictionary<string, Item> GetChildren()
    {
        return _children;
    }

    public override Item? GetChild(string name)
    {
        if (_children.ContainsKey(name))
        {
            return _children[name];
        }
        else
        {
            return null;
        }
    }

    #endregion
}
