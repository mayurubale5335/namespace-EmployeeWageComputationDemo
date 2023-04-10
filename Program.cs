using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;

            // welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            // UC1-EmployeeAttendance
            Random random = new Random();
           while(day<=NUMBER_OF_WORKING_DAYS && totalHrs<=MAX_WORKING_HRS)
            {
                int employeeAttendance = random.Next(0, 3); //0 or 1
                switch (employeeAttendance)
                {
                    case IS_FULL_TIME:
                        // code block
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        // code block
                        empHrs = 4;
                        break;
                    default:
                        // code block
                        empHrs = 0;
                        break;
                }

                //UC2
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Employee Wage for day{0} and {1}hrs is:{2}", day,empHrs, empWage);
                totalWage = totalWage + empWage;
                // totalWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            Console.WriteLine("TotalWage for {0} days and {1} hrs is:{2}", (day - 1),totalHrs, totalWage);
            Console.ReadLine();
        }
    }
}
