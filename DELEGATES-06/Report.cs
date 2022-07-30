using System;
namespace DELEGATES_06
{
    public class Report
    {
        public void ProcessEmployeeWith60000PlusSales(Employee[] employees)
        {
            Console.WriteLine("Employees With $60,000 + Sales");
            Console.WriteLine("-------------------------------------------");

            foreach (var e in employees)
            {
                if (e.TotalSales >= 60000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Gender} | {e.Name} | ${e.TotalSales} ");
                }
            }
            Console.WriteLine("\n\n");
        }

        public void ProcessEmployeeWithSalesBetween30000and59999(Employee[] employees)
        {
            Console.WriteLine("Employees With Sales Between $30000 And  $59,999 + Sales");
            Console.WriteLine("-------------------------------------------");

            foreach (var e in employees)
            {
                if (e.TotalSales < 60000m && e.TotalSales >= 30000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Gender} | {e.Name} | ${e.TotalSales} ");
                }
            }
            Console.WriteLine("\n\n");
        }

        public void ProcessEmployeeWithSalesBetweenLessThan30000(Employee[] employees)
        {
            Console.WriteLine("Employees With Sales Between $30000 And  $59,999 + Sales");
            Console.WriteLine("-------------------------------------------");

            foreach (var e in employees)
            {
                if (e.TotalSales < 30000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Gender} | {e.Name} | ${e.TotalSales} ");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
