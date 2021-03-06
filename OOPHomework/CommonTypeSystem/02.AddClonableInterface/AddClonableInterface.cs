﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("lala", "lol", "rofl", "hladilnika", 666, 088811111, "fu@gmail.bg",
                "Hardware manufacturing", Specialty.KST, University.FreeUniversity, Faculty.Technical);

            Student b = new Student("www", "lol", "rofl", "hladilnika", 666, 088811111, "fu@gmail.bg",
                "Hardware manufacturing", Specialty.KST, University.FreeUniversity, Faculty.Technical);

            Student s = new Student("aaa", "lol", "rofl", "hladilnika", 666, 088811111, "fu@gmail.bg",
                "Hardware manufacturing", Specialty.KST, University.FreeUniversity, Faculty.Technical);

            List<Student> initialList = new List<Student>();
            initialList.Add(a);
            initialList.Add(b);
            initialList.Add(s);

            foreach (var item in initialList)
            {
                Console.WriteLine(item.ToString());
            }

            List<Student> ClonedList = new List<Student>();

            foreach (var item in initialList)
            {
                ClonedList.Add((Student)item.Clone());
            }

            Console.WriteLine("\nPrinting the cloned list: ");
            foreach (var item in ClonedList)
            {
                Console.WriteLine(item.ToString());
            }

            ClonedList[0].GetFirstName = "change1";
            ClonedList[1].GetFirstName = "change2";
            ClonedList[2].GetFirstName = "change3";
            Console.WriteLine("\n\nPrinting the cloned list after change: ");
            foreach (var item in ClonedList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\nThe initial list: ");
            foreach (var item in initialList)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }

    enum Specialty
    {
        KST, SoftwareArchitechure, Lalala
    }
    enum University
    {
        SU, TU, VTU, NBU, FreeUniversity
    }
    enum Faculty
    {
        Technical, Sport, Blabla, lala
    }

    class Student : ICloneable
    {
        string firstName, secondName, lastName;
        int SSN;
        int mobilePhone;
        string permanentAddress;
        string email;
        string course;
        Specialty spec;
        University uni;
        Faculty fac;

        public string GetFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public Student(string firstName, string secondName, string lastName, string permanentAddress, int SSN, int mobilePhone,
                        string email, string course, Specialty spec, University uni, Faculty fac)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.SSN = SSN;
            this.mobilePhone = mobilePhone;
            this.permanentAddress = permanentAddress;
            this.email = email;
            this.course = course;
            this.spec = spec;
            this.uni = uni;
            this.fac = fac;
        }

        public override bool Equals(object obj)
        {
            Student lala = (Student)obj;
            if (this.firstName == lala.firstName && this.secondName == lala.secondName &&
                this.lastName == lala.lastName && this.SSN == lala.SSN &&
                this.permanentAddress == lala.permanentAddress && this.mobilePhone == lala.mobilePhone)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string message = firstName + " " + secondName + " " + lastName + " " + SSN;
            return message;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + firstName.GetHashCode();
                hash = hash * 23 + secondName.GetHashCode();
                hash = hash * 23 + lastName.GetHashCode();
                return hash;
            }
        }
        public static bool operator ==(Student x, Student y)
        {
            return x.Equals(y);
        }
        public static bool operator !=(Student x, Student y)
        {
            return !x.Equals(y);
        }

        public object Clone()
        {

            return new Student(firstName, secondName, lastName, permanentAddress, SSN, mobilePhone, email, 
                course, spec, uni, fac);
        }
    }
}
