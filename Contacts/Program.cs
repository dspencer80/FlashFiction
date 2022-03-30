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
            Console.WriteLine("*****************************");
            Console.WriteLine("CONTACTS");
            Console.WriteLine("*****************************");
            Console.WriteLine("Select Operation:");
            Console.WriteLine("1 Add new contact");
            Console.WriteLine("2 Display contact by phone number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Search Contacts");
            Console.WriteLine("Press 'x' to exit");


            var userInput = Console.ReadLine();

            var PhoneBook = new PhoneBook();

            while (true)
            {
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

                        Console.WriteLine("Contact number to search:");
                        var searchNumber = Console.ReadLine();
                        PhoneBook.DisplayContact(searchNumber);
                        break;

                    case "3":
                        PhoneBook.DisplayAllContacts();
                        break;

                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase =Console.ReadLine();

                        PhoneBook.DisplayMatchingContacts(searchPhrase);
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Please select a valid operation");
                        break;

                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();

            }

            

        }
    }
}
