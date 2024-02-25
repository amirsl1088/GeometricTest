namespace GeometricShapes
{
    public class Area
    {
        public double Circle(double radius)
        {
            var p = 3;
            return radius *radius* p;
        }

        public double Rectangle(double length,double width)
        {
            return length * width;
        }

        public double Square(double side)
        {
            return side * side;
        }

        public double Triangle(double bottomside,double height)
        {
            return (bottomside * height) / 2;
        }
    }
}