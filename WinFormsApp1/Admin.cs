using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Admin : Person
    {
        public decimal Salary { get; set; }
        public int WorkingHours { get; set; }
        public bool IsFullTime { get; set; }

        public Admin() : base("", "", "", "Administration")
        {
        }

        public Admin(string name, string telephone, string email, string role, decimal salary, int wh, bool isFullTime) : base(name, telephone, email, "Administration")
        {
            this.Salary = salary;
            this.WorkingHours = wh;
            this.IsFullTime = isFullTime;
        }

        public override string GetDetails()
        {
            string jobType = IsFullTime ? "Full-time" : "Part-time";
            return $"Name: {Name} - Phone: {Telephone} - Email: {Email} - Role: {Role}\nSalary: {Salary:C}\nWorking Hours: {WorkingHours}\nJob Type: {jobType}";
        }
    }
}
