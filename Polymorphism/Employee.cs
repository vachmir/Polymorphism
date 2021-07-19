using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
      abstract class Employee : IEnjoyable
    {
        protected string name;
        protected string surname;
        
        public virtual string Name { get { return name; } init { name=value; } }
        public virtual string Surname
        {
            get { return surname; }
            set { surname = value; }
        }


        public Employee()
        {

        }
        public Employee(string name)
        {
            this.name = name;
        }

        public virtual void Salary()
        {
            float amount = 150; //ինչպե՞ս սա փոխել Employee — ում 
            Console.WriteLine(amount);
        }

        //public virtual int Salary()
        //{
        //    int amount = 150;
        //    return amount;
        //}

        public void Print()
        {
            Console.WriteLine("Employee Enjoys his job"); ;
        }

        public abstract void Show();
        
        
    }
}
