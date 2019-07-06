using System;

namespace Shape
{
    public class Square : Rectangle
    {
        private double _side;

        public Square(double side) : base(side, side)
        {
            _side = side;
        }

        public double Side
        {
            get { return _side; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _side = value;
            }
        }

        public override double Length
        {
            get { return _side; }
        }

        public override double Width
        {
            get { return _side; }
        }

        public override void Zoom(double scaleLength, double scaleWidth)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (scaleLength != scaleWidth)
            {
                throw new ArgumentOutOfRangeException();
            }
            base.Zoom(scaleLength, scaleWidth);
        }

        public void Zoom(double scale)
        {
            Zoom(scale, scale);
        }
    }
}
