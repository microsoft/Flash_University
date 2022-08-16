namespace Template_Method;

/**
 * An Abstract Base Class with Template Methods
 *
 * The abstract primitives, hooks, and template methods
 * are grouped via regions
 */
public abstract class FileSystem
{
    #region abstract primitives

    protected abstract IEnumerable<string> DoListFiles();
    protected abstract void DoMakeFile(string filename);
    protected abstract File DoOpenFile(string filename);
    protected abstract void DoRemoveFile(File file);

    #endregion

    #region hooks

    protected virtual void BeforeRemoveFile(File file)
    {
    }

    // AfterRemoveFile, etc

    #endregion

    #region template methods

    public bool FileExists(string filename)
    {
        var allFiles = DoListFiles();
        return allFiles.Contains(filename);
    }

    public IEnumerable<string> ListFiles()
    {
        return DoListFiles();
    }

    public File CreateFile(string filename)
    {
        if (FileExists(filename)) throw new Exception("file " + filename + " already exists");

        DoMakeFile(filename);
        var file = DoOpenFile(filename);

        return file;
    }

    public File GetFile(string filename)
    {
        if (!FileExists(filename)) throw new Exception("file " + filename + " does not exist");

        return DoOpenFile(filename);
    }

    public void DeleteFile(string filename)
    {
        if (!FileExists(filename)) throw new Exception("file " + filename + " does not exist");

        var file = DoOpenFile(filename);

        BeforeRemoveFile(file);
        file.OnRemove();

        DoRemoveFile(file);
    }

    #endregion
}

/**
 * An Abstract Base Class with Template Methods
 *
 * The abstract primitives, hooks, and template methods
 * are grouped via regions
 */
public abstract class File
{
    public string Path { get; }

    protected File(string path)
    {
        Path = path;
    }

    #region abstract primitives

    protected abstract string DoRead();
    protected abstract void DoWrite(string content);

    #endregion

    #region hooks

    internal virtual void OnRemove()
    {
    }

    #endregion

    #region template methods

    public void Append(string newContent)
    {
        var existingContent = DoRead();
        DoWrite(existingContent + newContent);
    }

    public void Overwrite(string newContent)
    {
        DoWrite(newContent);
    }

    public string GetContent()
    {
        return DoRead();
    }

    #endregion
}