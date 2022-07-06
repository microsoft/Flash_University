
namespace Session_1.Composition
{
    public class Location
    {
        private int _x = 0;
        private int _y = 0;

        public Location() { }

        public Location(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X { get => _x; }
        public int Y { get => _y; }

        public Location Move(int dx, int dy)
        {
            return new Location(X + dx, Y + dy);
        }
    }
}
