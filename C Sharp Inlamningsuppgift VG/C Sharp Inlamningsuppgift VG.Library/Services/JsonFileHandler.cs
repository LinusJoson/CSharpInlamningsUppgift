using C_Sharp_Inlamningsuppgift_VG.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace C_Sharp_Inlamningsuppgift_VG.Library.Services
{
    public class JsonFileHandler
    {
        private readonly string _filePath;

        public JsonFileHandler(string filePath)
        {
            _filePath = filePath;
        }
        public List<Contact> LoadContacts()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Contact>();
            }

            try
            {
                var json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error loading contacts from JSON file: {ex.Message}");
                return new List<Contact>();
            }
        }
        public void SaveContacts(List<Contact> contacts)
        {
            try
            {
                var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving contacts to JSON file: {ex.Message}");
            }
        }
    }
}
