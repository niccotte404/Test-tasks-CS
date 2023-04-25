using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Drawing;

namespace ConsoleApp2
{
    class Program
    {
        public static int Main(string[] args)
        {
            Emploee emploee = new Emploee(new EmploeeInfo("Ke", "me", "ke", DateTime.Now, "Here", "Here", "Nu me"));

            Emploees emploees = new Emploees();
            
            emploees.ShowAllEmploeesInfo();
            emploees.AddEmploee(emploee);
            emploees.ShowAllEmploeesInfo();
            emploees.ChangeEmploeeInfo(new EmploeeInfo("Ke", "ke", "ke", DateTime.Now, "Here", "Here", "Nu ke"), emploee);
            emploees.ShowAllEmploeesInfo();
            
            return 0;
        }
    }
    
    public struct EmploeeInfo
    {
        public string Name { get; }
        public string Surame { get; }
        public string Middlename { get; }
        public DateTime DateOfBirth { get; }
        public string Adres { get; }
        public string Department { get; }
        public string AboutEmploee { get; }

        public EmploeeInfo(string name, string surname, string middlename, DateTime dateOfBirth, string adres, string department, string aboutEmploee)
        {
            Name = name;
            Surame = surname;
            Middlename = middlename;
            DateOfBirth = dateOfBirth;
            Adres = adres;
            Department = department;
            AboutEmploee = aboutEmploee;
        }
    }

    class Emploees
    {
        private List<Emploee> _emploees = new List<Emploee>
        {
            new Emploee(new EmploeeInfo("Me", "me", "ke", DateTime.Now, "Here", "Here", "Nu me")),
            new Emploee(new EmploeeInfo("Alex", "Alex", "Alex", DateTime.Now, "Here", "Here", "Nu me"))
        };

        public void ShowAllEmploeesInfo()
        {
            foreach (var emploee in _emploees)
            {
                emploee.ShowEmploeeInfo();
                Console.WriteLine();
            }
        }

        public void RemoveEmploee(Emploee emploee)
        {
            if (_emploees.IndexOf(emploee) == -1)
            {
                Console.WriteLine("There is no such emploee in the list");
                return;
            }
            _emploees.Remove(emploee);
        }

        public void AddEmploee(Emploee emploee)
        {
            _emploees.Add(emploee);
        }

        public void ChangeEmploeeInfo(EmploeeInfo emploeeInfo, Emploee emploee)
        {
            if (_emploees.IndexOf(emploee) == -1)
            {
                Console.WriteLine("There is no such emploee in the list");
                return;
            }
            _emploees[_emploees.IndexOf(emploee)].ChangeEmploeeInfo(emploeeInfo);
        }
    }

    class Emploee
    {
        private EmploeeInfo _privateEmploeeInfo;
        public Emploee(EmploeeInfo emploeeInfo)
        {
            _privateEmploeeInfo = emploeeInfo;
        }

        public void ShowEmploeeInfo()
        {
            Console.WriteLine($"Emploee: {_privateEmploeeInfo.Name} {_privateEmploeeInfo.Surame} {_privateEmploeeInfo.Middlename}\n" +
                              $"Date of birth: {_privateEmploeeInfo.DateOfBirth}\n" +
                              $"Adres: {_privateEmploeeInfo.Adres}\n" +
                              $"Department: {_privateEmploeeInfo.Department}\n" +
                              $"About Emploee: {_privateEmploeeInfo.AboutEmploee}");
        }

        public void ChangeEmploeeInfo(EmploeeInfo emploeeInfo)
        {
            _privateEmploeeInfo = emploeeInfo;
        }
    }
    
}