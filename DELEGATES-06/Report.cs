using System;
namespace DELEGATES_06
{
    public class Report
    {
        public delegate bool IllegibalSales(Employee e);

        public void ProcessEmployee(Employee[] employees,string title, IllegibalSales Isillegibal)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("  Id   |Gender |   Name        | TotalSales");
            Console.WriteLine("-------------------------------------------");

           
            foreach (var e in employees)
            {
                if (Isillegibal(e))
                {
                    Console.WriteLine($"  {e.Id}    |   {e.Gender}   |   {e.Name}   |    ${e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
     
    }
}
