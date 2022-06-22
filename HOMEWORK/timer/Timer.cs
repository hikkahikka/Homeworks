using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace timer
{
    public class Timer
    {
        /// <summary>
        /// <param name="time" структура в которой хранится время
        /// <param name="isLaunched" показывает запущен таймер или нет
        /// </summary>
        DateTime time;
        bool isLaunched = false;
        
        /// <summary>
        /// начало программы
        /// выбор между запуском таймера и выходом из приложение
        /// </summary>
        public void Start()
        {
            bool isRunning = true;
            while (isRunning)

            {
                
                Console.WriteLine("enter \"1\" to start timer\nenter \"0\" to exit");
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        Run();
                        break;
                    case '0':
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("wrong choice\ntry again");
                        break;
                }
            }
        }

        /// <summary>
        /// запускает таймер
        /// <param name="timeInMoment">получает текущее время </param> 
        /// создается второй поток для считывания нажатия клавиши во время работы таймера
        /// </summary>
        private void Run()
        {
            isLaunched = true;
            DateTime timeInMoment = DateTime.Now;
            time = new DateTime(
                timeInMoment.Year,
                timeInMoment.Month,
                timeInMoment.Day,
                timeInMoment.Hour,
                timeInMoment.Minute,
                timeInMoment.Second
                );
            
            Thread waitAnswer = new Thread(Question);
            waitAnswer.Start();

            Show();
        }

        /// <summary>
        /// вывод информациии таймера
        /// <param name="differenceTime">хранит в себе разницу между временем из Run() и текущим </param> 
        /// 
        /// </summary>
        private void Show()
        {
            while (isLaunched)
            {

                TimeSpan differenceTime = DateTime.Now.Subtract(time);
                if (differenceTime.Milliseconds == 0)
                {
                    Console.Clear();
                    Console.WriteLine(differenceTime.ToString("dd\\:mm\\:ss"));
                    Console.WriteLine("enter 0 to stop");
                }
            }
            Console.Clear();
            Console.WriteLine(DateTime.Now.Subtract(time).ToString("dd\\:mm\\:ss"));
        }
        /// <summary>
        /// ждет нажатия клавиши пользователем
        /// </summary>
        private void Question()
        {
            while (isLaunched)
            {
                char choice = Console.ReadKey().KeyChar;
                if(choice=='0') isLaunched = false;
            }
        }

    }
}
