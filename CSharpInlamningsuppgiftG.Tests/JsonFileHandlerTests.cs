
using System.Collections.Generic;
using System.IO;
using C_Sharp_Inlamningsuppgift_G.Models;
using C_Sharp_Inlamningsuppgift_G.Services;
using Xunit;

public class JsonFileHandlerTests
{
    [Fact]
    public void SaveAndLoadContacts_ShouldPersistData()
    {
       
        // Arrange
        string tempFilePath = "test_contacts.json";
        var handler = new JsonFileHandler(tempFilePath);

        var ContactsToSave = new List<Contact>
        {
            new Contact("Test1", "123456789", "John@jon.se"),
            new Contact("Test2", "123123123", "Buop@g.se")
        };

        // Act
        handler.SaveContacts(ContactsToSave);
        var loadedContacts = handler.LoadContacts();

        // Assert
        Assert.Equal(ContactsToSave.Count, loadedContacts.Count);
        Assert.Equal(ContactsToSave[0].Name, loadedContacts[0].Name);
        Assert.Equal(ContactsToSave[1].Email, loadedContacts[1].Email);

        // Clean up
        File.Delete(tempFilePath);
    }
}
