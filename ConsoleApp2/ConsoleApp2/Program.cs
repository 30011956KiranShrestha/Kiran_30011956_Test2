using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {        //*method*//
            Console.WriteLine("Welcome to staff payroll system");
            Console.WriteLine("enter 1. to display salary");
            Console.WriteLine("enter 2. to display wages");
            Console.Write("Please enter the button");
            int button = int.Parse(Console.ReadLine());

            {
                //* Salary Class *//
                Salary s1 = new Salary();
                Console.WriteLine($"In per week is your salary${Math.Round(s1.DisplaySalary(), 2)}");


                //*Two Blank Lines *//
                Console.WriteLine();
                Console.WriteLine();

            }

            {
                //* Wages Class *//
                Wages w1 = new Wages();
                Console.Write("Please enter your hour worked');
                    int hours = int.Parse(Console.ReadLine());
                Console.WriteLine($"Wages per week ${Math.Round(w1.DisplayWages(hours), 2)}");
                Console.ReadLine();
            }
            public class Salary
        {
            //* Variables *//
            public double annualsalary = 80000;
            public double weekly;

            //* getters and setters *//
            public double Annualsalary {  get { return annualsalary; } set { annualsalary = 80000; } }
            public double weeklysalary {  get { return weeklysalary; } set { weeklysalary = value; } }

            //* display the method of salary *//
            //* number of weeks 365/7 = 52 *//
            public double DisplaySalary()
            {
                double 80000 / 52;
                return $"per week salary is $ {Math.Round(income, 2)}";

                //*create the constructor *//
                public Salary()
                {
                    Console.WriteLine("your salary is 80000 per year");
                    Annualsalary = 80000
                }

                public class wages
            {
                // variables//
                private double hourlyrate;
                private double numHours;
                private double weeklyWages;

                // getters and setters //
                public double hourlyRate { grt { return hourlyRate; } set { hourlyRate = 33.72; } }
                public double NumHours { get { return numHours; } set { numHours = value; } }
                public double WeeklyWages { get { return weeklyWages; } set { weeklyWages = value} }

            }
            }
        }


        }
    }
}
