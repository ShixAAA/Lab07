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
            int[] PominovRate = {5,4,3,2,2,2,2 };
            Person person = new Person("Акимов Николай Владимирович", "Мужской", "16 января 2005", "Коровинсоке 24А", "baran@gmail.ru");
            person.Print();
            Console.WriteLine();
            Student student = new Student("31ИС", 3, PominovRate, "Поминов Даниил Дмитриевич", "Мужской", "9 мая 2004", "Булатниково", "LFYZ1212@mail.ru");
            student.Print();
            Console.WriteLine();
            Assessment assessment = new Assessment("РКИС", "Хрущенко Артем", "15.12.2022", PominovRate);
            assessment.Print();
            Console.WriteLine();
            Director director = new Director("Грицевкий Эрнест Аркадьевич", "Мужской", "16 февраля 2004", "Москва", "123@mail.ru", 10, "Среднее специальное");
            director.Print();
            Console.ReadKey();
        }
    }
}
