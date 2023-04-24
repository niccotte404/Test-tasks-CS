using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        public static int Main(string[] args)
        {
            
            return 0;
        }
    }

    class Company
    {
        private List<Emploee> _emploees = new List<Emploee>
        {
            new Emploee("Alex", "Director", 100000),
            new Emploee("John", "Worker", 30000)
        };

        public void ShowEmploeeList()
        {
            foreach (var emploee in _emploees)
            {
                Console.WriteLine($"Name: {emploee.Name}, Place: {emploee.Place}, Salary: {emploee.Salary}");
            }
        }

        public void AddEmploee(Emploee emploee)
        {
            _emploees.Add(emploee);
        }

        public void RemoveEmploee(Emploee emploee)
        {
            _emploees.Remove(emploee);
        }

        public List<Emploee> FindEmploee(string name)
        {
            var emploeesWithThisName = _emploees.Where(emploee => emploee.Name == name).ToList();
            return emploeesWithThisName;
        }

        public void ShowAllStats()
        {
            Console.WriteLine($"Amount of emploees: {_emploees.Count}");
            int averageSalary = 0;
            foreach (var emploee in _emploees)
            {
                averageSalary += emploee.Salary;
            }
            averageSalary = averageSalary / _emploees.Count;
            Console.WriteLine($"Average salary: {averageSalary}");
            Console.Write("All places: ");
            foreach (var emploee in _emploees)
            {
                Console.Write(emploee.Place + " ");
            }
            Console.WriteLine();
        }
    }
    
    class Emploee
    {
        public string Name { get; private set; }
        public string Place { get; private set; }
        public int Salary { get; private set; }

        public Emploee(string name, string place, int salary)
        {
            Name = name;
            Place = place;
            Salary = salary;
        }
        
    }
    
}