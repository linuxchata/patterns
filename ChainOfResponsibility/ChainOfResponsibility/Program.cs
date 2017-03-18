using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReportWithoutCoR();

            Console.WriteLine();

            ReportWithCoR();

            Console.ReadKey();
        }

        private static void ReportWithoutCoR()
        {
            // No CoR implementation
            Console.WriteLine("No Chain of Responsibility");

            var report = new ExpenseReport(200);

            var employees = new List<Employee>
            {
                new Employee("Pylyp", 0m),
                new Employee("Hasham", 100m),
                new Employee("Annalisa", 1000m),
                new Employee("Isabel", 10000m)
            };

            var approved = false;

            foreach (var employee in employees)
            {
                var response = employee.ApproveExpense(report);
                if (response != ApprovalResponse.BeyondApprovalLimit)
                {
                    Console.WriteLine("    Report was approved by {0}", employee.Name.ToUpper());
                    approved = true;
                    break;
                }
            }

            if (!approved)
            {
                Console.WriteLine("    No one was able to approve the report");
            }
        }

        private static void ReportWithCoR()
        {
            // CoR implementation
            Console.WriteLine("Chain of Responsibility");

            var report = new ExpenseReport(20000);
            var eh1 = new ExpenseHandler(new Employee("Pylyp", 0m));
            var eh2 = new ExpenseHandler(new Employee("Hasham", 100m));
            var eh3 = new ExpenseHandler(new Employee("Annalisa", 1000m));
            var eh4 = new ExpenseHandler(new Employee("Isabel", 10000m));

            eh1.SetNext(eh2);
            eh2.SetNext(eh3);
            eh3.SetNext(eh4);

            var response = eh1.Approve(report);

            Console.WriteLine("Response {0}", response);

        }
    }
}
