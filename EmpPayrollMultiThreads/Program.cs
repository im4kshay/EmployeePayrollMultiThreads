﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollMultiThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-Welcome to the Employee Payroll Using Multi Threads Program-=-=-=-=-=");

            List<Employee> employeeDetails = new List<Employee>();
            employeeDetails.Add(new Employee { EmployeeID = 1, EmployeeName = "Akshay" });
            employeeDetails.Add(new Employee { EmployeeID = 2, EmployeeName = "Poorva" });
            employeeDetails.Add(new Employee { EmployeeID = 3, EmployeeName = "Anuj" });
            employeeDetails.Add(new Employee { EmployeeID = 4, EmployeeName = "Manali" });

            EmployeeRepository repo = new EmployeeRepository();
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            repo.AddEmployeeToPayroll(employeeDetails);
            stopWatch1.Stop();
            Console.WriteLine("Duration without multi thread: " + stopWatch1.ElapsedMilliseconds + " ms");

            EmployeeRepository repo1 = new EmployeeRepository();
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            repo.AddEmployeeToPayroll(employeeDetails);
            stopWatch2.Stop();
            Console.WriteLine("Duration with multi thread: " + stopWatch2.ElapsedMilliseconds + " ms");

            Console.ReadLine();
        }
    }
}
