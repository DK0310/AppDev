using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Models;

namespace WinFormsApp1.Controllers
{
    public class PersonController
    {
        private List<Admin> admins;
        private List<Teacher> teachers;
        private List<Student> students;

        public PersonController()
        {
            admins = new List<Admin>();
            teachers = new List<Teacher>();
            students = new List<Student>();
        }

        // ==================== ADMIN OPERATIONS ====================
        public void AddAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin));
            admins.Add(admin);
        }

        public List<Admin> GetAllAdmins()
        {
            return new List<Admin>(admins);
        }

        public Admin GetAdmin(int index)
        {
            if (index >= 0 && index < admins.Count)
                return admins[index];
            return null;
        }

        public bool UpdateAdmin(int index, Admin updatedAdmin)
        {
            if (index >= 0 && index < admins.Count && updatedAdmin != null)
            {
                admins[index] = updatedAdmin;
                return true;
            }
            return false;
        }

        public bool DeleteAdmin(int index)
        {
            if (index >= 0 && index < admins.Count)
            {
                admins.RemoveAt(index);
                return true;
            }
            return false;
        }

        // ==================== TEACHER OPERATIONS ====================
        public void AddTeacher(Teacher teacher)
        {
            if (teacher == null)
                throw new ArgumentNullException(nameof(teacher));
            teachers.Add(teacher);
        }

        public List<Teacher> GetAllTeachers()
        {
            return new List<Teacher>(teachers);
        }

        public Teacher GetTeacher(int index)
        {
            if (index >= 0 && index < teachers.Count)
                return teachers[index];
            return null;
        }

        public bool UpdateTeacher(int index, Teacher updatedTeacher)
        {
            if (index >= 0 && index < teachers.Count && updatedTeacher != null)
            {
                teachers[index] = updatedTeacher;
                return true;
            }
            return false;
        }

        public bool DeleteTeacher(int index)
        {
            if (index >= 0 && index < teachers.Count)
            {
                teachers.RemoveAt(index);
                return true;
            }
            return false;
        }

        // ==================== STUDENT OPERATIONS ====================
        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return new List<Student>(students);
        }

        public Student GetStudent(int index)
        {
            if (index >= 0 && index < students.Count)
                return students[index];
            return null;
        }

        public bool UpdateStudent(int index, Student updatedStudent)
        {
            if (index >= 0 && index < students.Count && updatedStudent != null)
            {
                students[index] = updatedStudent;
                return true;
            }
            return false;
        }

        public bool DeleteStudent(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
                return true;
            }
            return false;
        }

        // ==================== SEARCH & FILTER ====================
        public List<Person> SearchByName(string name)
        {
            List<Person> results = new List<Person>();
            
            if (string.IsNullOrWhiteSpace(name))
                return results;

            results.AddRange(admins.FindAll(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)));
            results.AddRange(teachers.FindAll(t => t.Name.Contains(name, StringComparison.OrdinalIgnoreCase)));
            results.AddRange(students.FindAll(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)));
            
            return results;
        }

        public List<Person> GetAllPersons()
        {
            List<Person> allPersons = new List<Person>();
            allPersons.AddRange(admins);
            allPersons.AddRange(teachers);
            allPersons.AddRange(students);
            return allPersons;
        }

        public int GetTotalCount()
        {
            return admins.Count + teachers.Count + students.Count;
        }

        public void ClearAllData()
        {
            admins.Clear();
            teachers.Clear();
            students.Clear();
        }
    }
}
