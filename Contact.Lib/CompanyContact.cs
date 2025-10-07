using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Lib
{
    public class CompanyContact : Contact
    {
        private string _companyAdress;
        private string _telephoneNumber;

        public string CompanyAdress { get => _companyAdress; set => _companyAdress = value; }
        public string TelephoneNumber { get => _telephoneNumber; set => _telephoneNumber = value; }

        public CompanyContact(string firstName, string lastName, int age, string companyAdress, string telephoneNumber) : base(firstName, lastName, age)
        {
            _companyAdress = companyAdress;
            _telephoneNumber = telephoneNumber;
        }
        public override string ToString()
        {
            return base.ToString() + $"{_companyAdress} {_telephoneNumber}";
        }
        public override string FormatToSave(string fileName)
        {
            return base.FormatToSave(fileName) + ";" + CompanyAdress + ";" + TelephoneNumber;
        }
    }
}
