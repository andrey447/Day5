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

            Console.WriteLine("Укажите цвет фигуры:");
            Console.WriteLine("1 - зеленый");
            Console.WriteLine("2 - красный");
            Console.WriteLine("3 - синий");
            int color = Convert.ToInt32(Console.ReadLine());

            Figures[] figures = new Figures[3];
            figures[0] = new Rectangle();
            figures[1] = new Rhombus();
            figures[2] = new Triangles();

            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }

            switch (num)
            {
                case 1:
                    figures[0].Draw();
                    break;
                case 2:
                    figures[1].Draw();
                    break;
                case 3:
                    figures[2].Draw();
                    break;
            }
            
            Console.ResetColor();
        }
    }
}