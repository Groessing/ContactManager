using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Contact.Lib
{
    public class ContactManager
    {

        List<Contact> contacts = new List<Contact>();



        public ContactManager()
        {

        }
        public ContactManager(string firstName, string lastName)
        {
        }
        public ContactManager(string firstName, string lastName, int age)
        {

        }
        public void AddContact(Contact c)
         {
            
            contacts.Add(c);
        }

        public void AddPrivateContact(PrivateContact pc)
        {
            contacts.Add(pc);
        }

        public void AddCompanyContact(CompanyContact cc)
        {
            contacts.Add(cc);
        }


        public void ChangeName(int index, string firstName, string lastName)
        {
            contacts[index].Firstname = firstName;
            contacts[index].Lastname = lastName;
        }

        public void ChangeName(int index, int age)
        {
            contacts[index].Age = age;
        }


        public void DeleteContact(int index)
        {
            contacts.RemoveAt(index);
        }

        public Contact GetContact(int index)
        {
            return contacts[index];
        }

        public List<Contact> GetAllContacts()
        {
            
            return contacts;
        }

        public bool ExistsContact(string searchLastname)
        {
            bool result = false;
            for(int i = 0; i < contacts.Count; i++)
            {
                if (searchLastname == contacts[i].Lastname)
                {
                    result = true;
                    break;
                }
               
            }
            return result;

           
            
            
        }

        public void SaveToFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            for(int i=0; i < contacts.Count; i++)
            {
                string lines = contacts[i].FormatToSave(filename);
                sw.WriteLine(lines);
            }
        

            sw.Close();
            fs.Close();
            
        }

        public void ReadFromFile(string filename)

        {
            
            
                FileStream fs = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] linesplit = line.Split(';');
                    

                    if(linesplit.Length == 3)
                    {
                    contacts.Add(new Contact(linesplit[0], linesplit[1], Convert.ToInt32(linesplit[2])));
                    }

                    else if(linesplit.Length == 4)
                    {
                    contacts.Add(new PrivateContact(linesplit[0], linesplit[1], Convert.ToInt32(linesplit[2]), linesplit[3]));
                    }
                    else if(linesplit.Length == 5)
                    {
                    contacts.Add(new CompanyContact(linesplit[0], linesplit[1], Convert.ToInt32(linesplit[2]), linesplit[3], linesplit[4]));
                    }
                   

                }

                sr.Close();
                fs.Close();
            
            


            
           
        }
    }
}
