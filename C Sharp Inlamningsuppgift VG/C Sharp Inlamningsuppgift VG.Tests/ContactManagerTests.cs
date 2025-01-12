using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using C_Sharp_Inlamningsuppgift_VG.Library.Models;
using C_Sharp_Inlamningsuppgift_VG.Library.Services;

// namespace C_Sharp_Inlamningsuppgift_VG.Tests
// {
    public class ContactManagerTests
    {
        [Fact]
        public void AddContact_ShouldAddContact()
        {
            // Arrange
            var manager = new ContactManager("test_contacts.json");
            var contact = new Contact("Test", "123456789", "Jopp@g.se");

            // Act
            manager.AddContact(contact);
            var allContacts = manager.GetAllContacts();

            // Assert
            Assert.Single(allContacts);
            Assert.Equal(contact.Name, allContacts.First().Name);
        }
    }

// }
