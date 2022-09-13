using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1.Encapsulation
{
    /*
     * This demonstrates the concept of interface vs implementation.
     * The interface of each class is identical, but the implementation is different.
     * 
     * This means you could refactor either class to work exactly like the other
     * without having to update anywhere that uses it.
     */

    /**
     * This class computes the area lazily -
     * when the property is accessed.
     * 
     * It's public interface is:
     *     public int Width { get; set; }
     *     public int Height { get; set; }
     *     public int Area { get; }
     */
    public class LazyRectangle
    {
        public LazyRectangle(int width = 0, int height = 0)
        {
            Width = width;
            Height = height;
        }

        #region public members
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;

        public int Area { get => Width * Height; }
        #endregion
    }

    /**
     * This class computes the area eagerly -
     * the _area field is re-calculated whenever the width or height is set
     * 
     * It's public interface is also (all the additional fields/methods are private):
     *     public int Width { get; set; }
     *     public int Height { get; set; }
     *     public int Area { get; }
     */
    public class EagerRectangle
    {
        public EagerRectangle(int width = 0, int height = 0)
        {
            _width = width;
            _height = height;
            CalculateArea();
        }

        #region public members
        public int Width {
            get => _width;
            set {
                _width = value;
                CalculateArea();
            }
        }
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
                CalculateArea();
            }
        }

        public int Area { get =>_area; }
        #endregion

        #region private members (not part of the interface)
        private int _width = 0;
        private int _height = 0;

        private int _area;

        private void CalculateArea() {
            _area = _width * _height;
        }
        #endregion
    }
}
