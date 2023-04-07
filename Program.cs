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
            int isPresent = 1;
            // welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            // UC1-EmployeeAttendance
            Random random = new Random();
            int employeeAttendance = random.Next(0, 2); //0 or 1
            if(employeeAttendance==isPresent)
            {
                Console.WriteLine("employee Attendance is present");
            }
            else
            {
                Console.WriteLine("employee Attendance is absent");
            }
            Console.ReadLine();
        }
    }
}
