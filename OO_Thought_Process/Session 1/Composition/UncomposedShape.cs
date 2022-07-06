using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Composition
{
    /**
     * In this example all of the 'location' logic is contained within
     * this class itself. It does not use composition to abstract the
     * location logic into another class like the ComposedShape class does.
     */
    public class UncomposedShape
    {

        public UncomposedShape() { }

        public UncomposedShape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public void Move(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }

        public void MoveAbsolute(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
