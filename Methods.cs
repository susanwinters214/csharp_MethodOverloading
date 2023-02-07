using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_MethodOverloading
{
    internal class Methods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isDollars)
        {
           if (isDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
           else if (isDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
           else
            {
                return $"{x+y}";
            }
                    
        }

    }
}
