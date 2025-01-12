using System;
using System.Collections.Generic;

using C_Sharp_Inlamningsuppgift_G.Models;
using C_Sharp_Inlamningsuppgift_G.Services;


namespace C_Sharp_Inlamningsuppgift_G.UI
{
    
    class ConsoleUI
    {
        private readonly ContactManager _contactManager;

        public ConsoleUI(ContactManager contactManager)
        {
            _contactManager = contactManager;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Manager for contacts");
                Console.WriteLine("1. Show added contacts");
                Console.WriteLine("2. Add a new contact");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Choose an option!");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListContacts();
                        break;

                    case "2":
                        AddContact();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void ListContacts()
        {
            Console.Clear();
            Console.WriteLine("Contacts(ALL)");

            var contacts = _contactManager.GetAllContacts();
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            // Listar alla kontakter genom en foreach-loop. En if-sats används för att kontrollera om det finns några kontakter. Om det inte finns några kontakter skrivs "No contacts found" ut.

            Console.WriteLine("\nPress any key to return to menu");
            Console.ReadLine();
        }
        private void AddContact()
        {
            Console.Clear();

            string name = GetValidatedInput("Enter name : ", input => !string.IsNullOrWhiteSpace(input), "Name cannot be empty!");
            string phoneNumber = GetValidatedInput("Enter phone number : ", input => input.Length >= 7, "Phone number must be at least 7 digits long!");
            string email = GetValidatedInput("Enter email : ", input => input.Contains("@") && input.Contains("."), "Invalid email!");

            // A simpler form of validation for email. Could be more complex.

            var contact = new Contact(name, phoneNumber, email);
            _contactManager.AddContact(contact);


            Console.WriteLine("Contact added successfully!");
            Console.WriteLine("\nPress any key to return to menu");
            Console.ReadLine();

        }
        private string GetValidatedInput(string prompt, Func<string, bool> validationfunc, string errorMessage)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                // Nedanstående if-sats kontrollerar om input är null och om valideringsfunktionen är sann. Om båda är sanna returneras input. Detta för att undvika att programmet kraschar om användaren trycker på Enter utan att skriva något.
                if (input !=null && validationfunc(input))
                {
                    return input;
                }

                Console.WriteLine(errorMessage);
            }
        }
    }
}
