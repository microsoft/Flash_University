
namespace Equals
{
    internal class SimpleClass
    {
        internal int x { get; set; }
    }

    internal class InnocentClass: SimpleClass
    {
        public override bool Equals(object? obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 101;
        }
    }
}
