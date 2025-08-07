using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifierLabTask.Models
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (IsValidName(value))
                {
                    _name = Capitalize(value);
                }

            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                value = value.Trim();
                if (IsValidName(value))
                {
                    _surname = Capitalize(value);
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 10)
                {
                    _age = value;
                }

            }
        }
        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void Print()
        {

            Console.WriteLine($"Name:{Name}, Surname:{Surname}, Age{Age}");
        }
        public bool IsValidName(string name)
        {
            if (name.Trim().Length > 2)
            {

                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                    {
                        return false;
                    }


                }
            }
            return true;


        }
        public string Capitalize(string name)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(name[0]));
            for (int i = 1; i < name.Length; i++)
            {
                sb.Append(char.ToLower(name[i]));
            }
            return sb.ToString();
           
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname},  {Age}");
        }

    }
}
