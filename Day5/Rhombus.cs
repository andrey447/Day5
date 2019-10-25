using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class Rhombus : Figures
    {
        public override void Draw()
        {
            Console.WriteLine("      *");
            Console.WriteLine("    *   *");
            Console.WriteLine("  *       *");
            Console.WriteLine("*  rhombus *");
            Console.WriteLine("  *       *");
            Console.WriteLine("    *   *");
            Console.WriteLine("      *");
        }
    }
}
