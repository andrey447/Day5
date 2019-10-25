using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую фигуру нарисовать?");
            Console.WriteLine("1 - прямоугольник");
            Console.WriteLine("2 - ромб");
            Console.WriteLine("3 - треугольник");
            int num = Convert.ToInt32(Console.ReadLine());

            Figures[] figures = new Figures[3];
            figures[0] = new Rectangle();
            figures[1] = new Rhombus();
            figures[2] = new Triangles();

            foreach (Figures figs in figures)
            {
                figs.Draw();
            }
        }
    }
}