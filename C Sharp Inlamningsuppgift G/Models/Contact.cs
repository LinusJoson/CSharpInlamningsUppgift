// Följande kod skapar en "Contact".

using System;
using System.Collections.Generic;


namespace C_Sharp_Inlamningsuppgift_G.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}";
        }

    }



}