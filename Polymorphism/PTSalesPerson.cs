using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PTSalesPerson : SalesPerson
    {
        public override string Name { get => base.Name; init => base.Name= value; } 
        public override string Surname
        {
            get => base.Surname;
            set => base.Surname = value;
        }

        public PTSalesPerson()
        {

        }
        public PTSalesPerson(string name)
        {
            this.name = name;
            //base.name = name;
        }
    }
}
