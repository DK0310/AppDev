using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public class Person
    {
        public string Name { get; set; } = "";
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Role { get; private set; }

        public string getName() { return Name;}
        public void setName(string name) { this.Name = name; }

        public string getTelephone() { return Telephone; }
        public void setTelephone(string telephone) { this.Telephone = telephone; }
        public string getEmail() { return Email; }
        public void setEmail(string email) { this.Email = email; }

        public Person()
        {
        }

        public Person(string name, string telephone, string email, string role)
        {
            this.Name = name;
            this.Telephone = telephone;
            this.Email = email;
            this.Role = role;
        }

        public virtual string GetDetails()
        {
            return $"Name: {Name} - Phone: {Telephone} - Email: {Email} - Role: {Role}";
        }
    }
}

