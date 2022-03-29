using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my contact list.");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by Number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Search Contacts");


            var userInput = Console.ReadLine();

            var PhoneBook = new PhoneBook();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Contact Name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Contact Number");
                    var number = Console.ReadLine();

                    var newContact = new Contacts(name, number);
                    PhoneBook.AddContacts(newContact);

                    break;

                case "2":
                    
                    break;

                case "3":
                   
                    break;

                case "4":
                  
                    break;

                default: Console.WriteLine("Please select a valid operation");
                    break;

            }
        }
    }
}
