using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Student : Person
    {
        public string Sub1 { get; set; }
        public string Sub2 { get; set; }
        public string Sub3 { get; set; }

        public Student() : base("", "", "", "Student")
        {
        }

        public Student(string name, string telephone, string email, string role, string sub1, string sub2, string sub3) 
            : base(name, telephone, email, "Student")
        {
            this.Sub1 = sub1;
            this.Sub2 = sub2;
            this.Sub3 = sub3;
        }

        public override string GetDetails()
        {
            return $"Name: {Name}\nPhone: {Telephone}\nEmail: {Email}\nRole: {Role}\nSubject 1: {Sub1}\nSubject 2: {Sub2}\nSubject 3: {Sub3}";
        }
    }
}
