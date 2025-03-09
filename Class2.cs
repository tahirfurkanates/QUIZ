using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2 : Class1
    {
        public int TeamSize { get; set; }

        public override decimal CalculateBonus()
        {
            return Salary * 0.2m; // Yöneticiler için %20 prim
        }
    }

}