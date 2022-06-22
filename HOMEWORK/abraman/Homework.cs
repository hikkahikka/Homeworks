using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abraman
{
    class Homework
    {
        /// <summary>
        /// лист с задачами
        /// </summary>
        public List<Task> tasks;
        public Homework()
        {
            tasks = new List<Task>();
        }
        /// <summary>
        /// добавление задачи в список задач
        /// </summary>
        public void AddTask(string name, string condition,  Func<bool>  solving)
        {
            tasks.Add(new Task(name, condition, solving));
        }
        /// <summary>
        /// вывод выбранной задачи
        /// </summary>
        /// <param name="id">номер задачи</param>
        public void ChooseTask(int id)
        {
            if (0 <= id && id < tasks.Count)
            {
                tasks[id].ShowTask();
            }
        }
        /// <summary>
        /// меню с выводом
        /// </summary>
        public void showMenu()
        {
            Console.WriteLine("Список задач:\n-1 - выход");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i} - {tasks[i].Name}");
            }
        }
        /// <summary>
        /// начало программы
        /// </summary>
        public void Start()
        {
            Console.WriteLine("\nВыберите номер задачи из списка:");
            while (true)
            {
                showMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == -1) return;
                ChooseTask(choice);
                Console.WriteLine("выберите задачу: ");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
