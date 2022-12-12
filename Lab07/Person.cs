using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }

        public Person(string name, string gender, string birthday, string adress, string email)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
            Adress = adress;
            Email = email;
        } 

        public void Print() 
        {
            Console.WriteLine($"Человек: {Name} \nПол: {Gender}\nДата рождения: {Birthday}\nАдрес: {Adress}\nПочта: {Email}");
        }
    }
}
