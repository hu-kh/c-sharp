```c#
using System;

namespace StructClass
{
    public struct Punkt
    {
        public double x;
        public double y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;

            Console.WriteLine("Gib bitte px1 Punkte ein: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib bitte py1 Punkte ein: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib bitte px2 Punkte ein: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib bitte py2 Punkte ein: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Abstand ist: {PixelObj(x1, x2, y1, y2)}");
        }

        private static double PixelObj(double px1, double px2, double py1, double py2)
        {
            Punkt p1, p2;

            p1.x = px1;
            p1.y = px2;
            p2.x = py1;
            p2.y = py2;

            double abstand, xAbstand, yAbstand;
            xAbstand = p2.x - p1.x;
            yAbstand = p2.x - p1.x;
            abstand = Math.Sqrt(xAbstand * xAbstand + yAbstand * yAbstand);

            return abstand;
        }
    }
}

```
