using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InchVorBan
    {

        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; } = 8;

        private int _filds;

        public int p_write
        {
            set { _filds = value; }
        }
        public int p
        {

            get { return _filds; }
            set {

                if (value > 0)
                {
                    _filds = value;
                }
                else
                {
                    
                    throw new NullReferenceException("Name is Empty");
                }
                 }
        }
        public InchVorBan()
        {

        }
        public InchVorBan(int a, int b,int c)
        {
            MyProperty = a;
            MyProperty2 = b;
            _filds = c;

            Console.WriteLine("Arjeqner  "+a+" "+b+" "+ c);
        }

    }
}
