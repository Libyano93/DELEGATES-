using System;

namespace DELEGATES_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee{Id=1,Gender="M", Name="Younis Y.",TotalSales=65000m},
                new Employee{Id=2,Gender="F", Name="Reem R.",TotalSales=50000m},
                new Employee{Id=3,Gender="M", Name="Sultan S.",TotalSales=65000m},
                new Employee{Id=4,Gender="F", Name="Nora N.",TotalSales=40000m},
                new Employee{Id=5,Gender="M", Name="Waleed W.",TotalSales=42000},
                new Employee{Id=6,Gender="F", Name="Amira A",TotalSales=30000m},
                new Employee{Id=7,Gender="M", Name="Feras F.",TotalSales=16000m},
                new Employee{Id=8,Gender="F", Name="Tasnim T.",TotalSales=15000m},
            };

            var report = new Report();
            report.ProcessEmployeeWith60000PlusSales(emps);
            report.ProcessEmployeeWithSalesBetween30000and59999(emps);
            report.ProcessEmployeeWithSalesBetweenLessThan30000(emps);
            Console.ReadKey();
        }
    }
}
