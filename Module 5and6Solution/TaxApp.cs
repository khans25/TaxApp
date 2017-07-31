using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5and6Solution
{
    class TaxApp
    {
        static void Main(string[] args)
        {
            int employeeID;
            char employeeName;
            double monthlySalary;
            int payPeriods;
            string inValue;
            char anotherEmployee = 'N';
            DisplayInstructions();
            ReadKey();
            do
            {
                GetInputValues(out employeeID, out employeeName, out monthlySalary, out payPeriods);
                Tax ln = new Tax(employeeID, employeeName, monthlySalary, payPeriods);
                WriteLine();
                Clear();
                WriteLine(ln);
                WriteLine();
                WriteLine(ln.OutputData());
                WriteLine("\nWould you like to enter another employee? (Y or N)");
                inValue = ReadLine();
                anotherEmployee = Convert.ToChar(inValue);
            }

            while ((anotherEmployee == 'Y') || (anotherEmployee == 'y'));
        }

        static void DisplayInstructions()
        {
            WriteLine("TAX APPLICATION" +
                "\n\nThis application will ask you to input the Employee ID" +
                "\n Employee Name, Monthly Salary, Federal and State taxes (percentages)" +
                "\nnumber of pay periods per year" + 
                "\n\nPRESS ANY KEY TO CONTINUE");
        }

        static void GetInputValues(out int employeeID, out char employeeName, out double monthlySalary, out int payPeriods)
        {
            Clear();
            employeeID = ObtainEmployeeID();
            employeeName = ObtainEmployeeName();
            monthlySalary = ObtainMonthlySalary();
            payPeriods = ObtainPayPeriods();
        }

        public static int ObtainEmployeeID()
        {
            string stringValue;
            int employeeID;
            Write("Enter the Employee ID: ");
            stringValue = ReadLine();
            while ((int.TryParse(stringValue, out employeeID) == false)
                || employeeID < 0
                || employeeID > 1000)

            {
                Write("\nInvalid Employee ID entered.");
                Write("\nRe-enter the Employee ID: ");
                stringValue = ReadLine();
            }

            return employeeID;
        }

        public static char ObtainEmployeeName()
        {
            string stringValue;
            char employeeName;
            Write("Enter the Employee Name: ");
            stringValue = ReadLine();
            char.TryParse(stringValue, out employeeName);
            
            return employeeName;
        }

        public static double ObtainMonthlySalary()
        {
            string stringValue;
            double monthlySalary;
            Write("Enter the monthly salary: ");
            stringValue = ReadLine();
            while ((double.TryParse(stringValue, out monthlySalary) == false)
                || monthlySalary < 0
                || monthlySalary > 1000000)

            {
                Write("\nInvalid monthly entered.");
                Write("\nRe-enter the monthly salary ");
                stringValue = ReadLine();
            }

            return monthlySalary;
        }

       /* public static int ObtainFedTaxPercent()
        {
            string stringValue;
            int fedTaxPercent;
            Write("Enter the Federal Tax Percentage: ");
            stringValue = ReadLine();
            while ((int.TryParse(stringValue, out fedTaxPercent) == false)
                || fedTaxPercent < 0
                || fedTaxPercent > 50)

            {
                Write("\nInvalid Federal Tax Percentage entered.");
                Write("\nRe-enter the Federal Tax Percentage: ");
                stringValue = ReadLine();
            }

            return fedTaxPercent;
        }

        public static int ObtainStateTaxPercent()
        {
            string stringValue;
            int stateTaxPercent;
            Write("Enter the State Tax Percent: ");
            stringValue = ReadLine();
            while ((int.TryParse(stringValue, out stateTaxPercent) == false)
                || stateTaxPercent < 0
                || stateTaxPercent > 100)

            {
                Write("\nInvalid State Tax Percent.");
                Write("\nRe-enter the State Tax Percent: ");
                stringValue = ReadLine();
            }

            return employeeID;
        }
        */

        public static int ObtainPayPeriods()
        {
            string stringValue;
            int payPeriods;
            Write("Enter the number of pay periods per year: ");
            stringValue = ReadLine();
            while ((int.TryParse(stringValue, out payPeriods) == false)
                || payPeriods < 1
                || payPeriods > 500)

            {
                Write("\nInvalid number of pay periods entered.");
                Write("\nRe-enter the number of pay periods per year: ");
                stringValue = ReadLine();
            }

            return payPeriods;
        }
    }
}

