using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Assessment
    {
        public string Discipline { get; set; }
        public int[] Rate { get; set; }
        public string Teacher { get; set; }
        public string Date { get; set; }

        public Assessment (string discipline, string teacher, string date, int[] rate)
        {
            Discipline = discipline;
            Rate = rate;
            Teacher = teacher;
            Date = date;
        }

        public void Print()
        {
            Console.WriteLine($"Дисциплина: {Discipline}\nОценка:{Rate[1]}\nПреподаватель: {Teacher}\nДата сдачи:{Date}");
        }
    }
}
