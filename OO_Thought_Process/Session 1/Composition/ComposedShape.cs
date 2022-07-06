using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Composition
{
    /**
     * In this example we've abstracted the 'location' functionality into another class,
     * which we compose with the ComposedShape class.
     * 
     * The `_location` field is private and thus not a part of the public interface -
     * this means that to the outside world, this class is equivalent to the UncomposedShape
     * class that implemented the location logic (eg `move`) directly inside itself.
     */
    public class ComposedShape
    {
        private Location _location = new Location();

        public ComposedShape() { }

        public ComposedShape(int x, int y)
        {
            _location = new Location(x, y);
        }

        public int X { get => _location.X; }
        public int Y { get => _location.Y; }

        public void Move(int dx, int dy)
        {
            _location = _location.Move(dx, dy);
        }

        public void MoveAbsolute(int x, int y)
        {
            _location = new Location(x, y);
        }
    }
}
