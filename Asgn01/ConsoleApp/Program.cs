using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EigibilityClass;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean naturalCitizen;
            int birthYr;
            int yearsInUS;
            int termsServed;
            Boolean rebelled;
            if (args.Length != 6)
            {
                Console.WriteLine("Enter true if you are a US citizen, and false if not.");
                naturalCitizen = Boolean.Parse(Console.ReadLine());
                Console.WriteLine("Enter your year of birth in the format yyyy.");
                birthYr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of years you have lived in the US.");
                yearsInUS = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of prior terms you have served.");
                termsServed = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter true if you have rebelled against the US, and false if not.");
                rebelled = Boolean.Parse(Console.ReadLine());

                TestEligibility test = new TestEligibility(naturalCitizen, birthYr, yearsInUS, termsServed, rebelled);
                if (test.isEligible())
                {

                    Console.WriteLine("You are eligible to be prez ofthe US. Good luck campaigning!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You are ineligible to be president of the US. Phew!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                naturalCitizen = Boolean.Parse(args[1]);
                birthYr = int.Parse(args[2]);
                yearsInUS = int.Parse(args[3]);
                termsServed = int.Parse(args[4]);
                rebelled = Boolean.Parse(args[5]);
                TestEligibility test = new TestEligibility(naturalCitizen, birthYr, yearsInUS, termsServed, rebelled);
                if (test.isEligible())
                {

                    Console.WriteLine("You are eligible to be prez ofthe US. Good luck campaigning!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else { }
                Console.WriteLine("You are ineligible to be president of the US. Phew!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

