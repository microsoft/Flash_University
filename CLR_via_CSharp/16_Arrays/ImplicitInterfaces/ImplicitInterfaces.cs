FileStream[] fs = { new("string", FileMode.Append) };

ListMethod(fs);
CollectionMethod(fs);
EnumerableMethod(fs);

void ListMethod(IList<FileStream> fs)
{
    Console.WriteLine("IListMethod");
}

void CollectionMethod(ICollection<FileStream> fs)
{
    Console.WriteLine("CollectionMethod");
}

void EnumerableMethod(IEnumerable<FileStream> fs)
{
    Console.WriteLine("EnumerableMethod");
}
