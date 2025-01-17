﻿using SalarySystem.Models;

namespace SalarySystem.Interfaces
{
    public interface IAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Role { get; set; }
        public bool IsAdmin { get; set; }
    }
}