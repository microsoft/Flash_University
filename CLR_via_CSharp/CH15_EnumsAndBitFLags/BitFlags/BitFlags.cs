//from book

var actions = Actions.Read | Actions.Delete;


[Flags]
public enum Actions
{
    None = 0,
    Read = 0x0001,
    Write = 0x0002,
    ReadWrite = Read | Write,
    Delete = 0x0004,
    Query = 0x0008,
    Sync = 0x00010
}