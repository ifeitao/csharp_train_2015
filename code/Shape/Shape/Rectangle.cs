using System;

namespace Shape
{
    public class Rectangle
    {
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        private double _length;

        public virtual double Length
        {
            get { return _length; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _length = value;
            }
        }

        private double _width;
        public virtual double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _width = value;
            }
        }

        public double Area
        {
            get { return _length*_width; }
        }

        public double ComputeArea()
        {
            return _length * _width;
        }

        public virtual void Zoom(double scaleLength, double scaleWidth)
        {
            if (scaleLength <= 0 || scaleWidth<=0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _length *= scaleLength;
            _width *= scaleWidth;
        }
    }
}
