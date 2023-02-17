namespace ClassLibraryTest1
{

    public class Circle : Figure
    {

        double radius;

        public Circle(string name, double radius) : base(name)
        {

            if (radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                Console.WriteLine("Радиус не может быть отрицательным. Он станет положительным");
                this.radius = radius * (-1);
            }
        }

        public override void Area()
        {
            double s;
            s = Math.PI * radius * radius;
           
            Console.WriteLine("Площадь круга = {0}", s);
        }


    }
}
