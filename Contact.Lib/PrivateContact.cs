using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Lib
{
    public class PrivateContact : Contact
    {
        private string _emailAdress;

        public string EmailAdress { get => _emailAdress; set => _emailAdress = value; }

        public PrivateContact(string firstName, string lastName, int age, string emailAdress) : base(firstName, lastName, age)
        {
            _emailAdress = emailAdress;

        }

        public override string ToString()
        {
            return base.ToString() + $"{_emailAdress}";
        }
        public override string FormatToSave(string fileName)
        {
            return base.FormatToSave(fileName) + ";" + EmailAdress;
        }
    }
}
