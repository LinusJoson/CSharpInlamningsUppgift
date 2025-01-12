using System;
using System.Collections.Generic;

using C_Sharp_Inlamningsuppgift_G.Models;

namespace C_Sharp_Inlamningsuppgift_G.Services
    
{
    public class ContactManager
    {

        private readonly List<Contact> _contacts;
        private readonly JsonFileHandler _fileHandler;

        public ContactManager (string filePath)
        {
            _fileHandler = new JsonFileHandler(filePath);
            _contacts = _fileHandler.LoadContacts();
        }
        

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            _fileHandler.SaveContacts(_contacts);
        }

        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }
    }
}