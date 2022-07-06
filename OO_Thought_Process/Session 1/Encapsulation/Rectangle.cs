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
     * when the property is accessed
     */
    public class LazyRectangle
    {
        public LazyRectangle(int width = 0, int height = 0)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;

        public int Area { get => Width * Height; }
    }

    /**
     * This class computes the area eagerly -
     * the _area field is re-calculated whenever the width or height is set
     */
    public class EagerRectangle
    {
        private int _width = 0;
        private int _height = 0;

        private int _area;

        public EagerRectangle(int width = 0, int height = 0)
        {
            _width = width;
            _height = height;
            CalculateArea();
        }

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

        private void CalculateArea() {
            _area = _width * _height;
        }
    }
}
