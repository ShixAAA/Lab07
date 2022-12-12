using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rate = {5,4,3,2,2,2,2 }; 
            Person person = new Person("Акимов Николай Владимирович","Мужской","16 января 2005", "Коровинсоке 24А", "baran@gmail.ru");
            person.Print();
            Student student = new Student("31ИС", 3, rate, "Поминов Даниил Дмитриевич", "Мужской", "9 мая 2004", "Булатниково", "LFYZ1212@mail.ru");
            student.Print();
            Console.ReadKey();
        }
    }
}
