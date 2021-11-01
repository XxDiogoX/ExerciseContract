using System;
using ExercicioContract.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
using ExercicioContract.Entities;

namespace ExercicioContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department ' s name:");

            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);

            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.WriteLine("Date(DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valueperhour, hours);
                worker.Addcontract(contract);
            }
            Console.WriteLine();

            Console.WriteLine("Enter month and year to calculate  income (MM/YYYY): ");
            string monthofyear = Console.ReadLine();
            int month = int.Parse(monthofyear.Substring(0, 2));
            int year = int.Parse(monthofyear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthofyear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
