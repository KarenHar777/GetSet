using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            InchVorBan obj1 = new InchVorBan();
            Console.WriteLine(obj1.MyProperty2);
            
            InchVorBan obj2 = new InchVorBan(6,5,6);

            //obj2.p_write = 111;
            obj1.p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj1.p);
            Console.ReadKey();

        }
    }
}
