using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ContactManager.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contact.Lib.Contact> contacts = new List<Contact.Lib.Contact>();
        List<Contact.Lib.ContactManager> manager = new List<Contact.Lib.ContactManager>();
        Contact.Lib.ContactManager m = new Contact.Lib.ContactManager();


        #region General Contact
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(tbxFirstname.Text == "" || tbxLastname.Text == "")
            {
                MessageBox.Show("You didn't enter all the infos", "One or more infos are missing");
            }


            else
            {
                int age = -1;
                string firstname = tbxFirstname.Text;
                string lastname = tbxLastname.Text;
                if (tbxAge.Text != "")
                {
                    try
                    {
                        age = Convert.ToInt32(tbxAge.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("The input string has the wrong format!", "Wrong format");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("The input was to big!", "Big input");
                    }
                }
                
               



               
                    Contact.Lib.Contact c = new Contact.Lib.Contact(firstname, lastname, age);
                    m.AddContact(c);


                    lstAllContacts.Items.Add(firstname + " " + lastname + " " + age);
                    tbxFirstname.Text = "";
                    tbxLastname.Text = "";
                    tbxAge.Text = "";
                
               
            }
           
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (lstAllContacts.SelectedIndex > -1)
            {
                
                
                string item = Convert.ToString(lstAllContacts.Items[lstAllContacts.SelectedIndex]);
                string[] splittedItem = item.Split(' ');
                int age = Convert.ToInt32(splittedItem[2]);
                if (age > -1 && tbxAge.Text != "")
                {
                    MessageBox.Show("The age cannot be changed", "Change age");
                }
                else
                {
                    lstAllContacts.Items[lstAllContacts.SelectedIndex] = tbxFirstname.Text + " " + tbxLastname.Text + " " + age;
                 
                }


            }
            
            else
            {
                MessageBox.Show("You didn't select an item", "Error");

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
            if (lstAllContacts.SelectedIndex > -1)
            {
                lstAllContacts.Items.Remove(lstAllContacts.SelectedItem);
           

            }
            else
            {
                MessageBox.Show("You didn't select an item", "No item selected");

            }
           
         
        }


        private void BtnBirthday_Click(object sender, EventArgs e)
        {
            int index = lstAllContacts.SelectedIndex;
            if (lstAllContacts.SelectedIndex > -1)
            {
                Contact.Lib.Contact f = m.GetContact(index);
                f.Birthday();
                lstAllContacts.Items.RemoveAt(index);
                string firstName = f.Firstname;
                string lastName = f.Lastname;
                int age = f.Age;
                lstAllContacts.Items.Add(firstName + " " + lastName + " " + age);


            }
            else
            {
                MessageBox.Show("You didn't select an item", "Error");

            }
        }


        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Red;
        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightGray;
        }
        #endregion


        #region other things
        private void BtnDeleteList_Click(object sender, EventArgs e)
        {
            if(lstAllContacts.Items.Count == 0)
            {
                MessageBox.Show("The list is already empty!", "Empty List");
            }
            else
            {
                lstAllContacts.Items.Clear();
                contacts.Clear();
            }
            
        }
 
       

        private void BtnDeleteList_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteList.BackColor = Color.LightGray;
        }

        private void BtnDeleteList_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteList.BackColor = Color.Red;
        }

       

        private void BtnCloseProgram_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the program?", "Close Program", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxFileName.Text == "")
                {
                    MessageBox.Show("You didn't enter the file name!", "Empty file name");
                }
                else
                {
                    string filename = tbxFileName.Text;
                    m.SaveToFile(filename);
                }
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have the permission to create or this file!", "No permission");
            }
           
           
        }


        
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = tbxFileName.Text;
                m.ReadFromFile(filename);
                List<Contact.Lib.Contact> l = m.GetAllContacts();
                for (int i = 0; i < m.GetAllContacts().Count; i++)
                {

                    //lstAllContacts.Items.Add(m.GetAllContacts()[i].Firstname + " " + m.GetAllContacts()[i].Lastname + " " + m.GetAllContacts()[i].Age);
                   
                    if(l[i] is Contact.Lib.PrivateContact)
                    {
                        lstAllContacts.Items.Add(l[i].Firstname + " " + l[i].Lastname + " " + l[i].Age + " " + ((Contact.Lib.PrivateContact) l[i]).EmailAdress);
                    }


                    else if(l[i] is Contact.Lib.CompanyContact)
                    {
                        lstAllContacts.Items.Add(l[i].Firstname + " " + l[i].Lastname + " " + l[i].Age + " " + ((Contact.Lib.CompanyContact)l[i]).CompanyAdress + " " + ((Contact.Lib.CompanyContact)l[i]).TelephoneNumber);
                    }


                    else if (l[i] is Contact.Lib.Contact)
                    {
                        lstAllContacts.Items.Add(l[i].Firstname + " " + l[i].Lastname + " " + l[i].Age);
                    }


                }
            }


            catch (ArgumentException)
            {
                MessageBox.Show("An empty path is not allowed", "Empty path");
            }
            catch (System.IO.FileNotFoundException)
            { 
                MessageBox.Show("The file or directory cannot be found", "File cannot be found");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You don't have the permission to open this file!", "No permission");
            }

        }
        
        private void LstAllContacts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lstAllContacts.SelectedItem + "", "Selected Contact");
        }
        #endregion




        #region Private Contact
        private void BtnPrivateAdd_Click(object sender, EventArgs e)
        {
            if (tbxPrivateFirstName.Text == "" || tbxPrivateLastName.Text == "" || tbxPrivateEmail.Text == "")
            {
                MessageBox.Show("You didn't enter all the infos", "One or more infos are missing");
            }


            else
            {
                string firstname = tbxPrivateFirstName.Text;
                string lastname = tbxPrivateLastName.Text;
                string email = tbxPrivateEmail.Text;
                int age = -1;

                if(tbxPrivateAge.Text != "")
                {
                    try
                    {
                        age = Convert.ToInt32(tbxPrivateAge.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("The input string has the wrong format!", "Wrong format");
                    }
                }

               
                Contact.Lib.PrivateContact pc = new Contact.Lib.PrivateContact(firstname, lastname, age, email);
                m.AddPrivateContact(pc);
               


                lstAllContacts.Items.Add(firstname + " " + lastname + " " + age + " " + email);
                tbxPrivateFirstName.Text = "";
                tbxPrivateLastName.Text = "";
                tbxPrivateAge.Text = "";
                tbxPrivateEmail.Text = "";

            }
        }


        private void BtnPrivateChange_Click(object sender, EventArgs e)
        {
            if (lstAllContacts.SelectedIndex > -1)
            {

                string item = Convert.ToString(lstAllContacts.Items[lstAllContacts.SelectedIndex]);
                string[] splittedItem = item.Split(' ');
                int age = Convert.ToInt32(splittedItem[2]);
                if (age > -1 && tbxAge.Text != "")
                {
                    MessageBox.Show("The age cannot be changed", "Change age");
                }
                else
                {
                    lstAllContacts.Items[lstAllContacts.SelectedIndex] = tbxPrivateFirstName.Text + " " + tbxPrivateLastName.Text + " " + age + " " + tbxPrivateEmail.Text;
                }

            }

            else
            {
                MessageBox.Show("You didn't select an item", "Error");

            }
        }

        private void BtnPrivateDelete_Click(object sender, EventArgs e)
        {
            if (lstAllContacts.SelectedIndex > -1)
            {
                lstAllContacts.Items.Remove(lstAllContacts.SelectedItem);

            }
            else
            {
                MessageBox.Show("You didn't select an item", "No item selected");

            }
        }

        private void BtnPrivateBirthday_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrivateDelete_MouseEnter(object sender, EventArgs e)
        {
            btnPrivateDelete.BackColor = Color.Red;
        }

        private void BtnPrivateDelete_MouseLeave(object sender, EventArgs e)
        {
            btnPrivateDelete.BackColor = Color.LightGray;
        }
        #endregion


        #region Company Contact
        private void BtnCompanyAdd_Click(object sender, EventArgs e)
        {
            if (tbxCompanyFirstName.Text == "" || tbxCompanyLastName.Text == "" || tbxCompanyAdress.Text == "" || tbxCompanyTelephoneNumber.Text == "")
            {
                MessageBox.Show("You didn't enter all the infos", "One or more infos are missing");
            }


            else
            {
                string firstname = tbxCompanyFirstName.Text;
                string lastname = tbxCompanyLastName.Text;
                string adress = tbxCompanyAdress.Text;
                string telephoneNumber = tbxCompanyTelephoneNumber.Text;
                int age = -1;

                if (tbxCompanyAge.Text != "")
                {
                    try
                    {
                        age = Convert.ToInt32(tbxCompanyAge.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("The input string has the wrong format!", "Wrong format");
                    }

                    catch (OverflowException)
                    {
                        MessageBox.Show("The input was to big!", "Big input");
                    }
                }

               

                Contact.Lib.CompanyContact cc = new Contact.Lib.CompanyContact(firstname, lastname, age, adress, telephoneNumber);
                m.AddCompanyContact(cc);


                lstAllContacts.Items.Add(firstname + " " + lastname + " " + age + " " + adress + " " + telephoneNumber);
                tbxCompanyFirstName.Text = "";
                tbxCompanyLastName.Text = "";
                tbxCompanyAge.Text = "";
                tbxCompanyAdress.Text = "";
                tbxCompanyTelephoneNumber.Text = "";


            }
        }

        private void BtnCompanyChange_Click(object sender, EventArgs e)
        {
            if (lstAllContacts.SelectedIndex > -1)
            {

                string item = Convert.ToString(lstAllContacts.Items[lstAllContacts.SelectedIndex]);
                string[] splittedItem = item.Split(' ');
                int age = Convert.ToInt32(splittedItem[2]);
                if (age > -1 && tbxAge.Text != "")
                {
                    MessageBox.Show("The age cannot be changed", "Change age");
                }
                else
                {
                    lstAllContacts.Items[lstAllContacts.SelectedIndex] = tbxCompanyFirstName.Text + " " + tbxCompanyLastName.Text + " " + age + " " + tbxCompanyAdress.Text + " " + tbxCompanyTelephoneNumber.Text;
                }

            }

            else
            {
                MessageBox.Show("You didn't select an item", "Error");

            }
        }

        private void BtnCompanyDelete_Click(object sender, EventArgs e)
        {
            if (lstAllContacts.SelectedIndex > -1)
            {
                lstAllContacts.Items.Remove(lstAllContacts.SelectedItem);

            }
            else
            {
                MessageBox.Show("You didn't select an item", "No item selected");

            }
        }

        private void BtnCompanyBirthday_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompanyDelete_MouseEnter(object sender, EventArgs e)
        {
            btnCompanyDelete.BackColor = Color.Red;
        }

        private void BtnCompanyDelete_MouseLeave(object sender, EventArgs e)
        {
            btnCompanyDelete.BackColor = Color.LightGray;
        }
        #endregion


    }
}
