using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Manager : Employee,  IEnjoyable
    {
        //public override string Name
        //{
        //    get {return name; }       
        //    init { name = value; }
        //}

        public override string Name
        {
            get => base.Name;
            init => base.Name = value;
        }

        public override string Surname
        {
            get => base.Surname;
            set => base.Surname = value;
        }

        public Manager()
        {

        }
        public Manager(string name)
        {
            this.name = name;      
            //base.name = name;
        }

        public override void Salary()
        {
            base.Salary();
            Console.WriteLine();
        }
        //public override int Salary()
        //{
        //   return base.Salary();

        //}

        public override void Show()
        {
            Console.WriteLine("Manager ");
        }

        
    }
}
