using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Lib;


namespace ContactManager.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region list of contacts

           
            List<Contact.Lib.Contact> contacts = new List<Contact.Lib.Contact>();
            List<Contact.Lib.ContactManager> manager = new List<Contact.Lib.ContactManager>();
           

           
          
          
            int num = 0;
            #endregion


            #region important values
            
            
            #endregion



            #region Main program
            while (true)
            { 
                Console.WriteLine("1) Add new contact");
                Console.WriteLine("2) Change contact");
                Console.WriteLine("3) Delete contact");
                Console.WriteLine("4) Search contact");
                Console.WriteLine("5) Show all contacts");
                Console.WriteLine("10) Help");
                Console.WriteLine("0) Close program");
                Console.Write("Your choice => ");
                int choice = Convert.ToInt32(Console.ReadLine());


                #region 1) Add new contact

                if (choice == 1)
                {
                    Console.Write("First name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Do you want to enter the age? (y/n): ");
                    char yesNo = Convert.ToChar(Console.ReadLine());

                    if (yesNo == 'y')
                    {
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        contacts.Add(new Contact.Lib.Contact(firstName, lastName, age));
                        manager.Add(new Contact.Lib.ContactManager(firstName, lastName, age));
                    }
                    else
                    {
                        contacts.Add(new Contact.Lib.Contact(firstName, lastName));
                        manager.Add(new Contact.Lib.ContactManager(firstName, lastName));
                    }

                    manager[num].AddContact(contacts[num]);
                    num++;

                }
                #endregion




                #region 2) Change contact
                else if (choice == 2)
                {
                    Console.Write("Index: ");
                    int index = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Do you want to change the name? (y/n): ");
                    char changeName = Convert.ToChar(Console.ReadLine());

                    if (changeName == 'y')
                    {
                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();
                        manager[index].ChangeName(index, firstName, lastName);
                    }

                    Console.Write("Do you want to change the age? (y/n): ");
                    char changeAge = Convert.ToChar(Console.ReadLine());

                    if (changeAge == 'y')
                    {
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        manager[index].ChangeName(index, age);
                    }





                }
                #endregion


                #region 3) Delete contact
                else if (choice == 3)
                {
                    Console.Write("Index: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    manager[index].DeleteContact(index);
                }
                #endregion



                #region 4) Search contact
                else if (choice == 4)
                {
                    Console.WriteLine("Which lastname would you like to search?: ");
                    string searchLastName = Console.ReadLine();
                    for (int i = 0; i < num; i++)
                    {
                        bool exists = manager[i].ExistsContact(searchLastName);

                        if (exists == true)
                        {
                            Console.WriteLine("The last name exists in the contacts");
                            break;
                        }

                        else
                        {

                            Console.WriteLine("The last name doesn't exist in the contacts");

                        }
                    }




                    Console.ReadKey();
                }
                #endregion




                #region 5) Show all contacts
                else if (choice == 5)
                {

                    for (int i = 0; i < num; i++)
                    {
                        List<Contact.Lib.Contact> newC = manager[i].GetAllContacts();
                        if (newC != null)
                        {
                            Console.WriteLine(newC[0].Firstname);
                            Console.WriteLine(newC[0].Lastname);
                            Console.WriteLine(newC[0].Age);
                        }

                    }


                    Console.ReadKey();
                }
                #endregion


                #region 10) Help
                else if (choice == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine();


                    Console.WriteLine("Useful helps");
                    Console.WriteLine("At first you have to enter the number of contacts you want to create");
                    Console.WriteLine("To change the number of contacts you have to restart the program");
                    Console.WriteLine("If you restart the program, all contacts you added will be lost");



                    Console.WriteLine();



                    Console.WriteLine("1) Add new contact");
                    Console.WriteLine("Here you add a new contact where you enter the name and the age (as long as you want)");



                    Console.WriteLine();



                    Console.WriteLine("2) Change contact");
                    Console.WriteLine("Here you can change the contact you choose");
                    Console.WriteLine("You always can change the name, but you can only change the age once as long as you didn't enter the age before");



                    Console.WriteLine();



                    Console.WriteLine("3) Delete contact");
                    Console.WriteLine("Here you can delete the contact you choose");



                    Console.WriteLine();



                    Console.WriteLine("4) Search contact");
                    Console.WriteLine("Here you can search for a last name");
                    Console.WriteLine("It will tell you if the last name you entered exists in the contacts at least once");



                    Console.WriteLine();



                    Console.WriteLine("5) Show all contacts");
                    Console.WriteLine("Here it shows you all the contacts you added");

                    Console.ReadKey();
                }
                #endregion



                #region 0) Close program
                else if (choice == 0)
                {
                    break;
                }
                #endregion




                #region all other numbers
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! The number you entered doesn't exists");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any button to continue");

                    Console.ReadKey();
                }
                #endregion
            }
            #endregion
        }
    }
}
