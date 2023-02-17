namespace ClassLibraryTest1
{
    public class Triangle : Figure
    {

        double a, b, c;

        public Triangle(string name, double a, double b, double c) : base(name)
        {

            if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
            {
                this.a = a; this.b = b; this.c = c;
            }
            else
            {
                Console.WriteLine("Некорректные значения a, b, c. Сторонам будет присвоена длина равная 1");
            }
        }

        public bool IsTrue()
        {

            if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) || (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)) || (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))) return true;
            else return false;
           
        }

        public override void Area()
        {
            double p, s;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь треугольника = {0}", s);
            Console.WriteLine(IsTrue());
        }


    }
}
