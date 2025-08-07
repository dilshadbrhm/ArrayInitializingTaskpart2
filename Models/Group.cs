using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifierLabTask.Models
{
    internal class Group
    {
        string _name;
        int _groupLimit;
        Student[] _students = new Student[0];

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (value.Length > 2)
                {
                    _name = value;
                }
            }
        }
        public int GroupLimit
        {
            get
            {
                return _groupLimit;
            }
            set
            {
                if (value > 0)
                    _groupLimit = value;
            }
        }
        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }

        }
        
        public void Add(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length - 1] = student;


        }
        public void Remove(string name)
        {
            int index = 0;
            Student[] newArray = new Student[_students.Length - 1];
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Name == name)
                {
                    index = i;
                    break;
                }
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (index != i)
                {
                    newArray[i] = Students[i];
                }
                else
                {
                    newArray[i] = Students[i + 1];
                }
            }
            Students = newArray;
        }
        public bool StudentExists(string name)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Name == name)
                    return true;
            }
            return false;
        }
        public void ShowStudents()
        {
            for (int i = 0; i < _students.Length; i++)
            {
                _students[i].PrintInfo();
            }

        }
    }
}




