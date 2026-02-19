using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Models
{
    public class Teacher : Person
    {
        public decimal Salary { get; set; }
        public string Sub1 { get; set; }
        public string Sub2 { get; set; }

        public Teacher() : base("", "", "", "Teaching Staff")
        {
        }

        public Teacher(string name, string telephone, string email, string role, decimal salary, string sub1, string sub2) 
            : base(name, telephone, email, "Teaching Staff")
        {
            this.Salary = salary;
            this.Sub1 = sub1;
            this.Sub2 = sub2;
        }
        public override string GetDetails()
        {
            return $"Name: {Name}\nPhone: {Telephone}\nEmail: {Email}\nRole: {Role}\nSalary: {Salary:C}\nSubject 1: {Sub1}\nSubject 2: {Sub2}";
        }
    }
}
