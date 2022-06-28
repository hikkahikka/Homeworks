using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    public class Subject
    {
        /// <summary>
        /// <param name="NAMES">возможные имена группы</param>
        /// <param name="name">имя предмета</param>
        /// <param name="remainingNames">список, в котором находятся уникальные случайные предметы </param>
        /// </summary>
        private static readonly string[] NAMES = new string[] { "Math", "Trud", "Physics", "Info", "PE", "History", "Bio", "Rus", "Eng", "Geog" };
        private static List<string> remainingNames;
        public string name;

        static Subject()
        {
            remainingNames = new List<string>();

            foreach (var name in NAMES)
            {
                remainingNames.Add(name);
            }
        }
        public Subject()
        {
            name = getRandomName();
        }
        private string getRandomName()
        {
            Random random = new Random();
            int id = random.Next(remainingNames.Count);
            string name = remainingNames[id];
            remainingNames.Remove(NAMES[id]);
            return name; 
        }
    }
}

