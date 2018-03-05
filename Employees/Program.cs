using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            Console.ReadLine();

            // Assume Manager has a constructor matching this signature:
            // (string fullName, int age, int empID,
            // float currPay, string ssn, int numbOfOpts)
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //double cost = chucky.GetBenefitCost();
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();


            // Define benefit level
            Employee.BenefitPackage.BenefitPackageLevel mybenefitLevel =
                Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            Console.ReadLine();


        }

        static void CastingExamples()
        {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager) frank);

            // A Manager "is-an" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            // A PTSalesPerson "is-a" SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);
            // Hexagon hex = (Hexagon)frank;
            // Use "as" to test compability.
            Hexagon hex2 = frank as Hexagon;
            if (hex2 == null)
                Console.WriteLine("Sorry, frank is not a Hexagon...");


        }

        static void GivePromotion(Employee emp)
        {
            // Increase pay...
            // Give new parking space in company garage...
            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson) emp).SalesNumber);
                Console.WriteLine();
            }

            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager) emp).StockOptions);
                Console.WriteLine();

            }




        }
    }
}
