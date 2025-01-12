using System;
using System.Collections.Generic;

using C_Sharp_Inlamningsuppgift_VG.ConsoleApp.UI;
using C_Sharp_Inlamningsuppgift_VG.Library.Services;

namespace C_Sharp_Inlamningsuppgift_VG.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var filePath = "contacts.json";
            var contactManager = new ContactManager(filePath);
            var consoleUI = new ConsoleUI(contactManager);

            consoleUI.ShowMenu();
        }
    }
}
