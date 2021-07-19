using System;
using System.IO;

namespace Polymorphism
{
    class Program 
    {

        static void Main(string[] args)
        {            
            Manager manager = new Manager() { Name = "John" };        //init member initialization
            manager.Surname = "Smidth";
            Console.WriteLine($"Manager's name is {manager.Name}");            
            Console.WriteLine($"Manager's surname is {manager.Surname}");
           
            Manager anotherManger = new Manager("Mike");        //init member initialization
            anotherManger.Surname = "Stevens";
            Console.WriteLine($"Another manager's name is {anotherManger.Name}");
            Console.WriteLine($"Another manager's surname is {anotherManger.Surname}");

            Console.WriteLine();

            PTSalesPerson partTimeSalesPerson = new PTSalesPerson("Jack");
            partTimeSalesPerson.Surname = "Griffin";
            Console.WriteLine($"Part time Samesperson's name is {partTimeSalesPerson.Name}");
            Console.WriteLine($"Part time Samesperson's surename is {partTimeSalesPerson.Surname}");
            Console.WriteLine();

            #region Casting
            Employee empMan = new Manager();
            //Manager nm = new Employee(); //Describe
            //Employee emp = new Employee(); //Can not work just because of abstract keyword
            SalesPerson spPTSP = new PTSalesPerson();
            //PTSalesPerson pts = new SalesPerson(); //Base class is not Derived class
            Employee empPTSP = new PTSalesPerson();
            //PTSalesPerson pT = new Employee();
            Employee empSP = new SalesPerson();
            
            #endregion

            #region Is and As

            object[] obj = new object[6];
            obj[0] = new PTSalesPerson();
            obj[1] = new SalesPerson();
            obj[2] = "C#";
            obj[3] = 334.5;
            obj[4] = null;
            obj[5] = new Manager();

            for (int i = 0; i < obj.Length; i++)
            {
                Employee item = obj[i] as PTSalesPerson;  // PTSalesPerson item = obj[i] as SalesPerson; //Base class can not be as derived class
                Console.WriteLine($"Line {i}, {item}");
            }

            if (spPTSP is SalesPerson)
            {
                //Console.WriteLine("partTimeSalesPerson is Employee");
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("XXXXXXXXXXXXXX");
            }
            #endregion

            IEnjoyable.MyProperty = 5;
            Console.WriteLine(IEnjoyable.MyProperty);
                       

        }
    }
}
