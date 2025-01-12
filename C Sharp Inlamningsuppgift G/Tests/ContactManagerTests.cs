 
using System.Linq;
using C_Sharp_Inlamningsuppgift_G.Models;
using C_Sharp_Inlamningsuppgift_G.Services;
using Xunit;

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
