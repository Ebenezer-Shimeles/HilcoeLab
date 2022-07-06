namespace shapes
{

    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(new Circle(10).calculateArea());
            Console.WriteLine(new Reactangle(10, 20).calculateArea());

            Console.WriteLine(new Circle(10).calculatePermimeter());
            Console.WriteLine(new Reactangle(10, 20).calculatePermimeter());
        }

    }

    public class Circle : IShape
    {
        static double PI = 3.142;
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }


        public double calculateArea()
        {
            return Math.Pow(_radius, 2) * PI;
        }

        public double calculatePermimeter()
        {
            return 2 * PI * _radius;
        }
    }
    class Reactangle : IShape
    {
        private double _width;
        private double _height;
        public Reactangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double calculateArea()
        {
            return _width * _height;
        }

        public double calculatePermimeter()
        {
            return (_width + _height) * 2;
        }
    }

    public interface IShape
    {

        double calculateArea();
        double calculatePermimeter();
    }

}