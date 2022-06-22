using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abraman
{
   /// <summary>
   /// класс с заданием
   /// </summary>

    public class Task
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">название задачи</param>
        /// <param name="condition">условие задачи</param>
        /// <param name="solving">делегат содержащий ссылку на решение задачи</param>
        /// 
        public string Condition { get; private set; }
        public string Name { get; private set; }
        public Func<bool> _solving;


        /// <summary>
        /// конструктор
        /// </summary>
        public Task() { }
        public Task(string name, string condition, Func<bool> solving):this()
        {
            Name = name;
            Condition = condition;
            _solving = solving;
        }
        /// <summary>
        /// функция вывода решения
        /// </summary>
        public void ShowTask()
        {
            Console.WriteLine($"Task: {Name}\n{Condition}");
            Console.WriteLine("\n\n");
            _solving();
        }
        
    }
}
