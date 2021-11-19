using System;
using System.Globalization;

namespace BeecrowdAlgorithmChallengeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SalaryWithBonus();
        }

        #region Salary-beecrowd | 1008
        /*
         beecrowd | 1008
                Salary
        Adapted by Neilor Tonin, URI  Brazil
        Timelimit: 1
         
        Write a program that reads an employee's number, his/her worked hours number in a month and the amount he received per hour. Print the employee's number and salary that he/she will receive at end of the month, with two decimal places.

        Don’t forget to print the line's end after the result, otherwise you will receive “Presentation Error”.
        Don’t forget the space before and after the equal signal and after the U$.
        Input
        The input file contains 2 integer numbers and 1 value of floating point, representing the number, worked hours amount and the amount the employee receives per worked hour.

        Output
        Print the number and the employee's salary, according to the given example, with a blank space before and after the equal signal.
         */
        public static void Salary()
        {
            Employer employer = new Employer();

            employer.Number = Convert.ToInt32(Console.ReadLine());
            employer.WorkedHours = Convert.ToInt32(Console.ReadLine());
            employer.SalaryPerHours = Convert.ToDouble(Console.ReadLine());

            double salary = employer.WorkedHours * employer.SalaryPerHours;

            Console.WriteLine("NUMBER = " + employer.Number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("0.000", CultureInfo.InvariantCulture));
        }

        public struct Employer
        {
            public int Number { get; set; }
            public int WorkedHours { get; set; }
            public double SalaryPerHours { get; set; }

        }
        #endregion

        #region SalaryWithBonus| beecrowd | 1009

        /*
         beecrowd | 1009
        Salary with Bonus
        Adapted by Neilor Tonin, URI  Brazil

        Timelimit: 1
        Make a program that reads a seller's name, his/her fixed salary and the sale's total made by himself/herself in the month (in money). Considering that this seller receives 15% over all products sold, write the final salary (total) of this seller at the end of the month , with two decimal places.

        - Don’t forget to print the line's end after the result, otherwise you will receive “Presentation Error”.

        - Don’t forget the blank spaces.

        Input
        The input file contains a text (employee's first name), and two double precision values, that are the seller's salary and the total value sold by him/her.

        Output
        Print the seller's total salary, according to the given example.

        Input Samples	Output Samples
        JOAO
        500.00
        1230.30

        TOTAL = R$ 684.54

        PEDRO
        700.00
        0.00

        TOTAL = R$ 700.00

        MANGOJATA
        1700.00
        1230.50

        TOTAL = R$ 1884.58*/

        public static void SalaryWithBonus()
        {
            var seller = new Seller();
            seller.Name = Console.ReadLine();
            seller.Salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double bonus = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            seller.Total = (bonus * 0.15) + seller.Salary;

            Console.WriteLine("TOTAL = R$ " + seller.Total.ToString("0.00", CultureInfo.InvariantCulture));
        }

        public struct Seller
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public double Total { get; set; }
        }

        #endregion
    }
}