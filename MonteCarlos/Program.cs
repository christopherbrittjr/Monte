using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlos
{
    struct Coordinate
    {
        public double x;
        public double y;

        public Coordinate(Random Rnd)
        {
            this.x = Rnd.NextDouble();
            this.y = Rnd.NextDouble();
        }
    }
    
    class Program
    {   
        
        public static double Hypotenuse(Coordinate dot)
        {
            double hypotenuse = Math.Sqrt((Math.Pow(dot.x, 2) + Math.Pow(dot.y, 2)));
            return hypotenuse;
        }

    static void Main(string[] args)
        {
            int place = 0;
            Random Rnd = new Random();

            do
            {
                double point = 0;

                Console.WriteLine("How many times would you like to run this program?");
                place = int.Parse(Console.ReadLine());
               
                Coordinate[] coord = new Coordinate[place];
                for (int i = 0; i < coord.Length; i++)
                {
                    coord[i] = new Coordinate(Rnd);
                }
                for (int i = 0; i < coord.Length; i++)
                {
                    if (Hypotenuse(coord[i]) <= i)
                    {
                        point++;
                    }
                }

                double overlapping = point / coord.Length;
                overlapping *= 4;
                Console.WriteLine($"{overlapping}");
                Console.WriteLine($"The overall difference from pi is {overlapping - Math.PI}");
                Console.ReadLine();
            }
            while (place != 0);
        }
    }
}
