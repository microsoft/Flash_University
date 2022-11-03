namespace Composite.FileSystem;

/*
 * TODO Exercise: what "common operations" should this include?
 */

/**
 * The "Component" base class
 *
 * Provides a common interface for both leaf objects,
 * and composite objects.
 */
public abstract class Item
{
    protected Item(string name, Item? parent)
    {
        Name = name;
        Parent = parent;
    }

    public Item? Parent { get; }

    #region Common Operations

    public string Name { get; }
    public abstract string DisplayName { get; }
    public abstract int SizeOnDisk { get; } // # of characters

    public string AbsoluteName
    {
        get
        {
            if (Parent == null)
            {
                return Name;
            }
            else
            {
                return Parent.AbsoluteName + "/" + Name;
            }
        }
    }

    #endregion

    #region Child Managment

    public abstract void Add(Item item);

    public abstract void Remove(string name);

    public abstract Dictionary<string, Item> GetChildren();

    public abstract Item? GetChild(string name);

    #endregion
}