using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{

    public class Student
    {
        private static readonly string[] NAMES = new string[] { "Boris", "Lenya", "Masha", "Dasha", "Petya", "Senya", "Marik", "Filip","Vanya","Vitya" };
        public string name;
        public Marks[] marks;


        public Student(Subject[] subjects)
        {
            name = getRandomName();

            marks = getRandomMarks(subjects);
        }

        private string getRandomName()
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(NAMES.Length);
            return (NAMES[index]);
        }
        private Marks[] getRandomMarks(Subject[] subjects)
        {
            Random randomValue = new Random();
            Marks[] marks = new Marks[subjects.Length];
            
            for(int i = 0; i<marks.Length; i++)
            {
                marks[i] = new Marks(randomValue.Next(1, 6), subjects[i]);
            }
            return marks;

        }

        public int getMark(Subject subject)
        {
            int value = 0;
            foreach(var mark in marks)
            {
                if (mark.subject == subject)
                {
                    value = mark.mark;
                    break;
                }


            }
            return value;
        }

        public float getAVGMarks()
        {
            float sum = 0;
            int kolvo = 0;
            foreach (var mark in marks)
            {
                sum += mark.mark;
                kolvo++;
            }
            return sum / kolvo;
        }
    }
}
