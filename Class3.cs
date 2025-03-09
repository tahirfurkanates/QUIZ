using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3 : Class2
    {
    public string About { get; set; }

        public override decimal CalculateBonus()
        {
            return Salary * 0.1m;
        }
    }
}