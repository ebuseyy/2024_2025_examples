using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_variables
{
    internal class degerlendirme2
    {
        public void deger(int d)
        {
            if (d < 100)
            {
                Console.WriteLine("değerimiz 100 den küçüktür");
            }
            else
            {
                Console.WriteLine("değerimiz 100 den büyüktür");
            }
        }
    }
}
