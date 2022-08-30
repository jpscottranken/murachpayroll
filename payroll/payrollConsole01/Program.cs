using System;

/*
 *      INPUTS          PROCESSING              OUTPUTS
 *      ==================================================
 *      firstName       INPUT firstName         firstName
 *      lastName        INPUT lastName          lastName
 *      hours           INPUT hours             hours
 *      rate            INPUT rate              rate
 *                      CALCULATE gross         gross
 *                      OUTPUT firstName
 *                      OUTPUT lastName
 *                      OUTPUT hours
 *                      OUTPUT rate
 *                      OUTPUT gross
 */

namespace payrollConsole01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            decimal hours;      //  Hours worked
            decimal rate;       //  Hourly rate
            decimal gross;      //  Gross pay (hours * rate)

            //  Input firstName, lastName, hours, rate
            Console.Write("Input first name: ");
            firstName = Console.ReadLine();

            Console.Write("Input last name: ");
            lastName = Console.ReadLine();

            Console.Write("Input hours worked: ");
            hours = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Input hourly rate: ");
            rate = Convert.ToDecimal(Console.ReadLine());

            //  Calculate gross pay
            gross = hours * rate;

            //  Output everything
            Console.Clear();
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name:  " + lastName);
            Console.WriteLine("Hrs Worked: " + hours.ToString("n2"));
            Console.WriteLine("Hrly Rate:  " + rate.ToString("c"));
            Console.WriteLine("Gross Pay:  " + gross.ToString("c"));

            Console.ReadLine();
        }
    }
}
