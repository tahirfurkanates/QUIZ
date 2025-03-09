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
            Class2 class2 = new Class2
            {
                Id = 1,
                Name = "Ahmet Yılmaz",
                Salary = 10000,
                Department = "Management",
                TeamSize = 10
            };

            Class3 class3 = new Class3
            {
                Id = 2,
                Name = "Ayşe Demir",
                Salary = 8000,
                Department = "Development",
                About = "React Developer"
            };

            Console.WriteLine($"{class2.Name} Bonus: {class2.CalculateBonus()} TL");
            Console.WriteLine($"{class3.Name} Bonus: {class3.CalculateBonus()} TL");
            Console.ReadKey();
        }
    }
}
