using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class Rectangle : Figures
    {
        public override void Draw()
        {
            Console.WriteLine("**************");
            Console.WriteLine("*            *");
            Console.WriteLine("*            *");
            Console.WriteLine("*            *");
            Console.WriteLine("*  rectangle *");
            Console.WriteLine("*            *");
            Console.WriteLine("*            *");
            Console.WriteLine("*            *");
            Console.WriteLine("**************");
        }
    }
}
