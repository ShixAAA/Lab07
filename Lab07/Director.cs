using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Director : Person
    {
        public int Experience { get; set; }
        public string Education { get; set; }

        public Director(string name, string gender, string birthday, string adress, string email ,int experience, string education) 
            : base (name, gender, birthday, adress, email)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
            Adress = adress;
            Email = email;
            Experience = experience;
            Education = education;
        }

        public void Print() 
        {
            Console.WriteLine($"Директор: {Name}\nПол: {Gender}\nДата рождения: {Birthday}\nАдрес: {Adress}\nПочта: {Email}\nСтаж работы: {Experience} лет\nОбразование:{Education}");
        }
    }
}
