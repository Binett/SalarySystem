﻿using SalarySystem.Models;
using System;
using System.Collections.Generic;

namespace SalarySystem.Utilities
{
    public static class InputHelper
    {
        public static void DeleteInfo(Employees employee)
        {
            Console.WriteLine($"\nUsername: {employee.UserName}   Password: {employee.Password}");
            Console.WriteLine("Enter username and password to delete this user");
        }

        public static Employees EmployeeToDelete(List<Employees> list)
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            return list[choice - 1];
        }

        public static string EnterFirstName()
        {
            Console.Write("Enter firstname: ");
            return Console.ReadLine();
        }

        public static bool EnterIfAdminOrNot()
        {
            Console.Write("Enter [admin] if admin. Otherwise press enter: ");
            string input = Console.ReadLine();
            if (input == "admin")
            {
                return true;
            }
            return false;
        }

        public static string EnterPassword()
        {
            Console.Write("Enter Password: ");
            return Console.ReadLine();
        }

        public static Roles EnterRole()
        {
            ListOfRoles();
            Console.Write("Enter the number of the role: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            return (Roles)choice - 1;
        }

        public static decimal EnterSalary()
        {
            Console.Write("Enter salary: ");
            return Convert.ToDecimal(Console.ReadLine());
        }

        public static string EnterSurname()
        {
            Console.Write("Enter surname: ");
            return Console.ReadLine();
        }

        public static string EnterUsername()
        {
            Console.Write("Enter username: ");
            return Console.ReadLine();
        }

        public static void ListOfRoles()
        {
            int counter = 1;
            foreach (var role in Enum.GetNames(typeof(Roles)))
            {
                Console.WriteLine($"{counter}. {role}");
                counter++;
            }
        }
    }
}