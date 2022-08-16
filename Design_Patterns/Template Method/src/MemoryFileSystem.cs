namespace Template_Method;

/**
 * A Concrete Subclass of FileSystem
 *
 * This class implements the primitive operations to
 * store files in-memory.
 */
public class MemoryFileSystem : FileSystem
{
    private readonly Dictionary<string, MemoryFile> _files = new();

    #region primitive operations

    protected override IEnumerable<string> DoListFiles()
    {
        return _files.Keys;
    }

    protected override void DoMakeFile(string filename)
    {
        _files.Add(filename, new MemoryFile(filename));
    }

    protected override File DoOpenFile(string filename)
    {
        return _files[filename];
    }

    protected override void DoRemoveFile(File file)
    {
        _files.Remove(file.Path);
    }

    #endregion

    #region hooks

    protected override void BeforeRemoveFile(File file)
    {
        Console.WriteLine("[[internal]] removing file {0} from memory store", file.Path);
    }

    #endregion
}

/**
 * A Concrete Subclass of File
 *
 * This class implements the primitive operations to
 * store files in-memory.
 *
 * Note - MemoryFile does not override the OnRemove hook
 */
internal class MemoryFile : File
{
    private string _content = "";

    public MemoryFile(string path) : base(path)
    {
    }

    #region primitive operations

    protected override string DoRead()
    {
        return _content;
    }

    protected override void DoWrite(string content)
    {
        _content = content;
    }

    #endregion
}