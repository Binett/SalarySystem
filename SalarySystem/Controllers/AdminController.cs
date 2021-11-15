﻿using SalarySystem.Data;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System;

namespace SalarySystem.Controllers
{
    public class AdminController
    {
        public void AdminMenu(Employees employee)
        {
            EmployeeHelper helper = new();
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Show info");
                Console.WriteLine("2. Show info about all employees");
                Console.WriteLine("3. Add employee");
                Console.WriteLine("4. Delete employee");
                Console.WriteLine("5. Logout");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        helper.ShowInfoAboutThisEmployee(employee);
                        break;

                    case 2:
                        helper.ShowListOfEmployees(DataStructure.EmployeesList);
                        break;

                    case 3:
                        helper.AddNewEmployee(DataStructure.EmployeesList);
                        break;
                    case 4:
                        helper.DeleteEmployeesAccount(DataStructure.EmployeesList);
                        break;
                    case 5:
                        Console.WriteLine("Logging out");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}