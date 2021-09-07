using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, Contact> ContactInformation { get; set; }

        public AddressBook()
        {
            ContactInformation = new Dictionary<string, Contact>();
        }

        public void AddContact(Contact contact)
        {
            try
            {
                ContactInformation.Add(contact.Email, contact);
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine($"An error occurred when trying to add duplicate contact: {ex}\n");
            }

}

        public Contact GetByEmail(string email)
        {
           if(ContactInformation.TryGetValue(email, out Contact contact))
           {
               return ContactInformation[email];
           }
           else
           {
               Console.WriteLine($"Contact {email}, not found in contact list");
               Contact notFound = new Contact();
               return notFound;
           }

        }
    }



}