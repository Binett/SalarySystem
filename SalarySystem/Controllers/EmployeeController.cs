﻿using SalarySystem.Data;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System;

namespace SalarySystem.Controllers
{
    public class EmployeeController
    {
        public void EmployeeMenu(Employees employee)
        {
            EmployeeHelper helper = new();
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Show info");
                Console.WriteLine("2. Delete this user");
                Console.WriteLine("3. Logout");
                Console.Write("Choice: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(employee.GetUserInfo());
                            break;

                        case 2:
                            if (helper.DeleteMyAccount(employee, DataStructure.EmployeesList)){ loop = false;}
                            break;

                        case 3:
                            Console.WriteLine("Logging out");
                            loop = false;
                            break;

                        default:
                            Console.WriteLine("The input needs to match one of the menu choices!");
                            Console.ReadKey();
                            break;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                   
                }
                Console.ReadKey();
            }
        }
    }
}