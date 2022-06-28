using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    public class ProgrammManager
    {
        private static Group group;

        static ProgrammManager()
        {
            group = new Group();
        }

        public static void StartDialogMenu()
        {
            string choice;
            Console.WriteLine("1 - show group marks as table\n" +
                                 "2 - show average marks in students\n" +
                                 "3 - show average marks in subjects\n" +
                                 "4 - show average mark in group\n" +
                                 "5 - show least and max marks in subjects\n" +
                                 "0 - exit\n");
            do
            {
               
                Console.Write("\nEnter number>> ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        group.showTableMarks();
                        break;

                    case "2":
                        group.showAVGMarksStudents();
                        break;

                    case "3":
                        group.showAVGMarksStudentInSubject();
                        break;

                    case "4":
                        group.showAVGMarksInGroup();
                        break;

                    case "5":
                        group.showMinMaxStudents();
                        break;

                    case "0":
                        break;

                    default:
                        Console.Write("Incorrect. try again\n");
                        break;
                }

                
                
            } while (choice != "0");
            Console.WriteLine("bb ;(");
        }
    }
}
