using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Student : Person
    {
        public string Group { get; set; }
        public int Course { get; set; }
        public int[] Rate { get; set; }

        public Student(string group, int course, int[] rate, string name, string gender, string birthday, string adress, string email) 
            : base(name, gender, birthday, adress, email)
        {
            Name = name;
            Group = group;  
            Course = course;
            Rate = rate;
            Gender = gender;
            Birthday = birthday;
            Adress = adress;
            Email = email;
            
        }
        private double AvgRate()
        {
            int sum = 0;
            for (int i = 0; i < Rate.Length; i++)
            {
                sum += Rate[i];
            }
            return sum / Rate.Length;
        }
        public void Print() 
        {
            Console.WriteLine($"Студент: {Name} \nПол: {Gender}\nДата рождения: {Birthday}\nАдрес: {Adress}\nПочта: {Email}\nГруппа: {Group}\nКурс:{Course}\nСредняя оценка: {AvgRate()}");
        }
    }
}
