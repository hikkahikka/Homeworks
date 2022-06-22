using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// в классе HomeworkApp пишутся решения задач в качестве функций класса
/// в функции Start с помощью homework.addTask() добавляются задачи в программу. 
/// функция addTask получает три аргумента: название задачи, условие задачи и указатель на функцию ее решения
/// </summary>
namespace abraman
{
    class Program
    {
        static void Main()
        {

            HomeworkApp launch = new HomeworkApp();
            launch.Start();
        }
    }
}
