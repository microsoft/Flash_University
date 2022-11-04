//from book

var actions = Actions.Read | Actions.Delete;
Console.WriteLine((int) actions);
//001
//100
//or on every column
//101
//2^0*1 + 2^1*0 + 2^2*1 = 4+1 = 5
[Flags]
public enum Actions
{
    None = 0, 
    Read = 0x0001, // 001
    Write = 0x0002,
    ReadWrite = Read | Write,
    Delete = 0x0004, //100
    Query = 0x0008,
    Sync = 0x00010
}