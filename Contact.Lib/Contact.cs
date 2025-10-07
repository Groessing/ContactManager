using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Contact.Lib
{
    public class Contact
    {
        protected string _firstname;
        protected string _lastname;
        protected int _age;
        protected string _name;

        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (_age == -1)
                {
                    _age = value;
                }

            }
        }

        public string Name { get => _firstname + "-" + _lastname; set => _name = value; }
        public string DisplayData
        {
            
            get
            {
                return Name;
            }
        }

        public Contact(string name)
        {
            _name = name;
        }

        public Contact()
        {

        }

        public Contact(string surename, string lastname)
        {
            

            _firstname = surename;
            _lastname = lastname;
            _age = -1;
        }
        public Contact(string surename, string lastname, int age)
        {


            _firstname = surename;
            _lastname = lastname;
            _age = age;
        }
        


       /* public void ChangeAge(int changeAge)
        {
            if(_age > -1)
            {
                _age = changeAge;
            }
            
        }

        public void ChangeName(string changeName)
        {
            string[] splittedName = new string[2];
            splittedName = changeName.Split(' ');

            _surename = splittedName[0];
            _lastname = splittedName[1];
        }*/


        public void Birthday()
        {
            if(_age > -1)
            {
                _age++;
            }
            
        }

        public virtual string FormatToSave(string fileName)
        {
          

            return _firstname + ";" + _lastname + ";" + Age;

        }
    }
}
