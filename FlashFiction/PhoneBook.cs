using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFiction
{
    internal class PhoneBook
    {
        private List<Contacts> _contact { get; set; } = new List<Contacts>();
        private void DisplayContactDetails(Contacts contacts)
        {
            Console.WriteLine($"Contacts: {contacts.Name}, {contacts.Number}");
        }

        private void DisplayContactsDetails(List<Contacts> contacts)
        {
            foreach (Contacts contact in contacts)
            {
                DisplayContactDetails(contact);
            }
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
            DisplayContactsDetails(_contact);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContact = _contact.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContact);


        }
    }
}
