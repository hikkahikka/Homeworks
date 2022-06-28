using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    /// <summary>
    /// класс, хранящий параметры и методы группы
    /// </summary>
    public class Group
    {
        /// <summary>
        /// <param name="NAMES"> список возможных имен группы</param>
        /// <param name="name"> имя группы</param>
        /// <param name="students">массив студентов группы</param>
        /// <param name="subjects">массив предметов группы</param>
        /// </summary>
        private static readonly string[] NAMES = new string[] {"first group", "not first group", "middle group", "not last group", "last group"};
        public string name;
        public Student[] students;
        public Subject[] subjects;
        /// <summary>
        /// конструктор, делающий случайно делающий группу
        /// </summary>
        public Group()
        {
            name = getRandomName();
            subjects = getRandomSubjects();
            students = getRandomStudents(subjects);
        }

        /// <summary>
        /// выбирает случайное имени для группы
        /// </summary>
        /// <returns>возвращает имя группы</returns>
        private string getRandomName()
        {
            Random name = new Random();
            return NAMES[name.Next(NAMES.Length)];
        }

        /// <summary>
        /// составляет массив случайных предметов 
        /// </summary>
        /// <returns>возвращает случайный массив предметов</returns>
        private Subject[] getRandomSubjects()
        {
            Random random = new Random();
            Subject[] subjects = new Subject[random.Next(2,5)];
            for (int i = 0; i < subjects.Length; i++)
            {
                subjects[i]=new Subject();
            }
            return subjects;
        }

        /// <summary>
        /// составляет массив случайных студентов 
        /// </summary>
        /// <param name="subjects">массив предметов для того, чтобы расставить оценки</param>
        /// <returns>возвращает массив случайных студентов</returns>
        private Student[] getRandomStudents(Subject[] subjects)
        {
            Random random = new Random();
            int studentSize = random.Next(2, 6);
            Student[] students = new Student[studentSize];
            for (int i = 0; i < studentSize; i++)
            {
                students[i] = new Student(subjects);
            }
            return students;
        }






        /// <summary>
        /// вывод о средних оценках студентов по каждому предмету
        /// </summary>

        public void showAVGMarksStudentInSubject()
        {
            foreach (var subject in subjects)
            {
                Console.WriteLine($"Average mark in {subject.name} is: {getAVGMarksOfSubject(subject)}");
            }
        }

        /// <summary>
        /// получение средней оценки по предметам одного ученика
        /// </summary>
        /// <param name="subject">список предметов ученика</param>
        /// <returns>возвращает среднюю оценку по предметам одного ученика</returns>
        private float getAVGMarksOfSubject(Subject subject)
        {
            float sum = 0;
            int kolvo = 0;

            foreach (var student in students)
            {
                sum += student.getMark(subject);
                kolvo++;
            }
            return sum / kolvo;
        }

        /// <summary>
        /// вывод средней оценки в группе
        /// </summary>
        public void showAVGMarksInGroup()
        {
            float sum = 0;
            int kolvo = 0;
            foreach (var student in students)
            {
                foreach (var subject in subjects)
                {
                    sum += student.getMark(subject);
                    kolvo++;
                }
            }

            Console.WriteLine($"Average score of \"{name}\" group is: {sum / kolvo}");
        }


        /// <summary>
        /// вывод таблицы с оценками
        /// </summary>
        public void showTableMarks()
        {
            Console.Write("\t");
            foreach (var subject in subjects)
            {
                Console.Write($"{subject.name}\t");
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"\n{students[i].name}\t");
                for (int j = 0; j < subjects.Length; j++)
                {
                    Console.Write($"{students[i].getMark(subjects[j])}\t");
                }
            }
        }
        /// <summary>
        /// вывод среднего балла студента
        /// </summary>
        public void showAVGMarksStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name}'s average score is: {student.getAVGMarks()}");
            }
        }

        /// <summary>
        /// вывод минимальных и максимальных оценок с указанием студентов
        /// </summary>
        public void showMinMaxStudents()
        {
            foreach (var subject in subjects)
            {
                Student slabiy = getStudentWithMinMark(subject);
                Student silniy = getStudentWithMaxMark(subject);
                Console.WriteLine($"student with lowest mark in {subject.name} is {slabiy.name}. His mark is {slabiy.getMark(subject)}");
                Console.WriteLine($"student with highest mark in {subject.name} is {silniy.name} with {silniy.getMark(subject)}\n");
            }
        }
        /// <summary>
        /// получение студента с худшим результатом
        /// </summary>
       
        
        private Student getStudentWithMinMark(Subject subject)
        {
            Student min = students[0];
            foreach (var student in students)
            {
                if (student.getMark(subject) < min.getMark(subject))
                    min = student;
            }
            return min;
        }
        /// <summary>
        /// получение студента с лучшим результатом
        /// </summary>
        private Student getStudentWithMaxMark(Subject subject)
        {
            Student max = students[0];
            foreach (var student in students)
            {
                if (student.getMark(subject) > max.getMark(subject))
                    max = student;
            }
            return max;
        }
    }
}
