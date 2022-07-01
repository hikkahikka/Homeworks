using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dostavka
{
    public class DeliveryManager
    {
        public static Food food = new Food();
        public static Builder builder = new FoodBuilder();
        public static ZakazDirector zakazDirector = new ZakazDirector(builder);
        

        public static void StartDoZakaz()
        {
            builder.CreateZakaz();
            builder.BuildBreakfast(DoBreakfastChange());
            

            builder.BuildSecondBreakfast(DoSecondBreakfastChange());
            

            builder.BuildLunch(DoLunchChange());
            
            builder.BuildSnack(DoSnackChange());
            
            builder.BuildDinner(DoDinnerChange());

            Console.WriteLine("Your order has been received, tell me how many days you want to arrange delivery?");
            food.numberOfDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("OK.\nYour check on one day is: " + 
                                 food.GetTotalPrice(builder)+ 
                                 "\nYour total check is: " + 
                                 food.GetTotalPrice(builder)*food.numberOfDays+ 
                                 "\nYour total kkals in one day is: "+ 
                                 food.GetTotalKkal(builder));
            
        }

        private static int DoBreakfastChange()
        {
            
            Console.WriteLine("Choose the dish on breakfast:");
            ShowVariantsMeal(food.GetBreakfast());
            while (true)
            {
                int selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 0)
                {
                    return -1;
                }
                else if(selection <= food.GetBreakfast().Length / food.GetBreakfast().GetLength(0) + 1)
                {
                    return (selection - 1);
                }
                
                else
                {
                    Console.WriteLine("Incorrect choice. Try again");
                }
            }
        }

        private static int DoSecondBreakfastChange()
        {

            Console.WriteLine("Choose the dish on second breakfast:");
            ShowVariantsMeal(food.GetSecondBreakfast());
            while (true)
            {
                int selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 0)
                {
                    return -1;
                }
                else if (selection <= food.GetSecondBreakfast().Length / food.GetSecondBreakfast().GetLength(0) + 1)
                {
                    return (selection - 1);
                }

                else
                {
                    Console.WriteLine("Incorrect choice. Try again");
                }
            }
        }
        private static int DoLunchChange()
        {

            Console.WriteLine("Choose the dish on lunch:");
            ShowVariantsMeal(food.GetLunch());
            while (true)
            {
                int selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 0)
                {
                    return -1;
                }
                else if (selection <= food.GetLunch().Length / food.GetLunch().GetLength(0) + 1)
                {
                    return (selection - 1);
                }

                else
                {
                    Console.WriteLine("Incorrect choice. Try again");
                }
            }
        }

        private static int DoSnackChange()
        {

            Console.WriteLine("Choose the dish on snack:");
            ShowVariantsMeal(food.GetSnack());
            while (true)
            {
                int selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 0)
                {
                    return -1;
                }
                else if (selection <= food.GetSnack().Length / food.GetSnack().GetLength(0) + 1)
                {
                    return (selection - 1);
                }

                else
                {
                    Console.WriteLine("Incorrect choice. Try again");
                }
            }
        }

        private static int DoDinnerChange()
        {

            Console.WriteLine("Choose the dish on dinner:");
            ShowVariantsMeal(food.GetDinner());
            while (true)
            {
                int selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 0)
                {
                    return -1;
                }
                else if (selection <= food.GetDinner().Length / food.GetDinner().GetLength(0) + 1)
                {
                    return (selection - 1);
                }

                else
                {
                    Console.WriteLine("Incorrect choice. Try again");
                }
            }
        }
        private static void ShowVariantsMeal(string[,] typeOfMeal)
        {
            string[] nameOfType = {"Name","Price","KKals"};

           
            
            for (int i = 0; i <typeOfMeal.GetLength(0); i++)
            {
                for (int j = 0; j < (typeOfMeal.Length/typeOfMeal.GetLength(0)); j++)
                {
                    Console.Write($"{i+1} - {nameOfType[j]}: {typeOfMeal[i, j]};  ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("If you don't want this meal select \"0\"");
        }
    }
}
