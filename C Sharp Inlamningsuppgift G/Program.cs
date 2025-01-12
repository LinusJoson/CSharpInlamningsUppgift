using System;
using System.Collections.Generic;

using C_Sharp_Inlamningsuppgift_G.Services;
using C_Sharp_Inlamningsuppgift_G.UI;

namespace C_Sharp_Inlamningsuppgift_G
{
    public class Program
    {
       public  static void Main(string[] args)
        {
           var filePath = "contacts.json";
            var contactManager = new ContactManager(filePath);
            var consoleUI = new ConsoleUI(contactManager);

            consoleUI.ShowMenu();
        }
    }
}
