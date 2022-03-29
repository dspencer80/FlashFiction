using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class PhoneBook
    {
        private List<Contacts> _contact { get; set; }
        private void DisplayContactDetails(Contacts contacts)
        {
            Console.WriteLine($"Contacts: {contacts.Name}, {contacts.Number}");
        }

        public void AddContacts(Contacts contacts)
        {
            _contact.Add(contacts);
        }

        public void DisplayContact(string number)
        {
            var contacts = _contact.FirstOrDefault(c => c.Number == number);
            if (contacts == null)
            {
                Console.WriteLine("Contact not Found");

            }
            else
            {
                DisplayContactDetails(contacts);
            }


        }

        public void DisplayAllContacts()
        {
           foreach (var contact in _contact)
            {

                DisplayContactDetails(contact);
            }
        }


    }
}
