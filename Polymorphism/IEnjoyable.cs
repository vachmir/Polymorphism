using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    interface IEnjoyable
    {
        public static int MyProperty { get; set; }
        public abstract void Print();
        public abstract void Show();
        public void Demonstrate()
        {
            Console.WriteLine("Demonstration");
        }
    }
}
