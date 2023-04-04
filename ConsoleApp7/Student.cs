using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp7
{
    internal class Student
    {
        #region PrivateFields
        private string _name;
        private int _age;
        private int _phoneNumber;
        private string _city;
        private string _country;
        private string _schoolName;
        private string _numberOfGroup;
        private static int _counterStudent;
        private int _idStudent;
        #endregion
        #region Properties
        public string Name
        {
            get => _name;
            set
            {
                if (value.Trim() != String.Empty) _name = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0 && value <= 120) _age = value;
            }
        }
        public int PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value > 0) _phoneNumber = value;
            }
        }
        public string City
        {
            get => _city;
            set
            {
                if (value.Trim() != String.Empty) _city = value;
            }
        }
        public string Country
        {
            get => _country;
            set
            {
                if (value.Trim() != String.Empty) _country = value;
            }
        }
        public string SchoolName
        {
            get => _schoolName;
            set
            {
                if (value.Trim() != String.Empty) _schoolName = value;
            }
        }
        public string NumberOfGroup
        {
            get => _numberOfGroup;
            set
            {
                if (value.Trim() != String.Empty) _numberOfGroup = value;
            }
        }
        public static int CounterStudent => _counterStudent;
        public int IdStudent => _idStudent;
        #endregion
         #region Methods
        public void SeyHello() => Console.WriteLine($"Привет студент {Name}.Вы приняти в школу {SchoolName} в группу {NumberOfGroup}." +
            $" Покажите свои документи пожайлуста.");
        public void Dokumenty() => Console.WriteLine($"Имя: {Name}\t Возраст: {Age}\t Тел.: {PhoneNumber}\t Город: {City}\t " +
            $"Страная: {Country}");
        public void NumberOfStudents() => Console.WriteLine($"Количество студентов: {CounterStudent}");
        #endregion
        #region Constructors
        public Student() : this("Bob") { }
        public Student(string name) : this(name, 90) { }
        public Student(string name, int age) : this(name, age, 050711025) { }
        public Student(string name, int age, int phoneNumber) : this(name, age, phoneNumber, "Київ") { }
        public Student(string name, int age, int phoneNumber, string city) : this(name, age, phoneNumber, city, "Україна") { }
        public Student(string name, int age, int phoneNumber, string city, string country) : this(name, age, phoneNumber, city, country, "Technology colege") { }
        public Student(string name, int age, int phoneNumber, string city, string country, string schoolName) : this(name, age, phoneNumber, city, country, schoolName, "Group number 1") { }
        public Student(string name, int age, int phoneNumber, string city, string country, string schoolName, string numberOfGroup)
        {
            Name = !String.IsNullOrWhiteSpace(name) ? name : "Bob";
            Age = age;
            PhoneNumber = phoneNumber;
            City = !String.IsNullOrWhiteSpace(city) ? city : "Київ";
            Country = !String.IsNullOrWhiteSpace(country) ? country : "Україна";
            SchoolName = !String.IsNullOrWhiteSpace(schoolName) ? schoolName : "Technology colege";
            NumberOfGroup = !String.IsNullOrWhiteSpace(numberOfGroup) ? numberOfGroup : "Group number 1";
            _counterStudent++;
            _idStudent = _counterStudent;
        }
        #endregion
    }
}