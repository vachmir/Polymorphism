using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SalesPerson : Employee
    {
        public override string Name { get; init; }
        public override string Surname
        {
            get => base.Surname;
            set => base.Surname = value;
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
