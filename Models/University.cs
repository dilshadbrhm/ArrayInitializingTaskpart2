using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifierLabTask.Models
{
    internal class University
    {
        string _name;
        Group[] _groups = new Group[0];

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
        public Group[] Groups
        {
            get
            {
                return _groups;
            }
            set
            {
                _groups = value;
            }
        }
        public University(string name)
        {
            Name = name;
        }
        public void AddGroup(Group group)
        {
            Array.Resize(ref _groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }
        public void Remove(string name)
        {
            int index = 0;
            Group[] newArray = new Group[Groups.Length - 1];
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].Name == name)
                {
                    index = i;
                    break;
                }
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (index != i)
                {
                    newArray[i] = Groups[i];
                }
                else
                {
                    newArray[i] = Groups[i + 1];
                }
            }
            Groups = newArray;
        }
        public void ShowGroups()
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                Console.WriteLine($"Group: {Groups[i].Name} (Limit: {Groups[i].GroupLimit})");
                Groups[i].ShowStudents();
            }
        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                Groups[i].ShowStudents();
            }
        }

    }
}
