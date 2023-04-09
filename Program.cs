using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empWage = 0;
            const int EMP_RATE_PER_HR = 20;
            // welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            // UC1-EmployeeAttendance
            Random random = new Random();
            int employeeAttendance = random.Next(0, 3); //0 or 1
            if (employeeAttendance == IS_FULL_TIME)
            {
                Console.WriteLine(" Fulltime employee Attendance is present");
                empHrs = 8;
            }
            else if (employeeAttendance == IS_PART_TIME)
            {
                Console.WriteLine("Parttime employee Attendance is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("employee Attendance is absent");
                //  empHrs = 0;
            }
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage is" + empWage);
            Console.ReadLine();
        }
    }
}
