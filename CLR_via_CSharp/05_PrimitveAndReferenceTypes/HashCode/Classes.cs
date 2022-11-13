namespace HashCode
{
    internal class SimpleClass
    {
        internal Int32 x { get; set; }
        internal Int32 y { get; set; }
        
    }

    internal class BetterEquals : SimpleClass
    {
        public override bool Equals(object? obj)
        {
            BetterEquals other = obj as BetterEquals;
            return x.Equals(other.x) && y.Equals(other.y);
        }
    }

    internal class BetterHashCode:BetterEquals
    {

        public override int GetHashCode()
        {
            return x^y; //xor operator return 1 if x_n =1 and y_n =0 or y_n =1 and x_n =0; else 0; why is it good?; could other things work?
        }
    }
}
