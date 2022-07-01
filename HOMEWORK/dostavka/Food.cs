using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dostavka
{
    public  class Food
    {
        /// <summary>
        /// массивы с вариантами еды
        /// </summary>
        private static readonly string[,] BREAKFAST = { { "Scrambled", "100", "260" }, {"Eggs toast","70","320" }, { "Porridge", "180", "125" },{ "Sausages" , "120", "280"} };//имя цена ккал
        private static readonly string[,] SECOND_BREAKFAST = { { "Fruits", "110", "70" }, { "Sandwich", "120", "155" }, { "Nuts", "180", "100" }, { "Cottage cheese", "100", "240" } };
        private static readonly string[,] LUNCH = { { "Borscht", "240", "100" }, { "Noodles", "200", "140" }, { "Pasta with cutlet", "210", "" }, { "Shawarma", "220", "500" } };
        private static readonly string[,] SNACK = { { "Sandwich", "120", "155" }, { "Ice cream", "100", "200" }, { "Yogurt", "70", "60" }, { "Chocopai", "40", "129" } };
        private static readonly string[,] DINNER = { { "Steak with rice", "390", "400" }, { "Potatoes with mushrooms", "270", "180" }, { "Strips", "170", "250" }, { "Sushi", "230", "270" } };

        public List<string[]?>? zakaz;

        public int numberOfDays;

        public string[,] GetBreakfast()
        {
            return BREAKFAST;
        }

        public string[,] GetSecondBreakfast()
        {
            return SECOND_BREAKFAST;
        }

        public string[,] GetLunch()
        {
            return LUNCH;
        }

        public string[,] GetSnack()
        {
            return SNACK;
        }

        public string[,] GetDinner()
        {
            return DINNER;
        }
        public void SetBreakfast(int breakfast)
        {
            if (breakfast != -1)
            {
                string[] buff = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    buff[i] += BREAKFAST[breakfast, i];
                }
                zakaz.Add(buff);
            }
            else zakaz.Add(null);
        }

        public void SetSecondBreakfast(int second_breakfast)
        {

            if (second_breakfast != -1)
            {
                string[] buff = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    buff[i] += SECOND_BREAKFAST[second_breakfast, i];
                }
                zakaz.Add(buff);
            }
            else zakaz.Add(null);
            
            
        }

        public void SetLunch(int lunch)
        {
            if (lunch != -1)
            {
                string[] buff = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    buff[i] += LUNCH[lunch, i];
                }
                zakaz.Add(buff);
            }
            else zakaz.Add(null);

        }

        public void SetSnack(int snack)
        {
            if (snack != -1)
            {
                string[] buff = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    buff[i] += SNACK[snack, i];
                }
                zakaz.Add(buff);
            }
            else zakaz.Add(null);
        }

        public void SetDinner(int dinner)
        {
            if (dinner != -1)
            {
                string[] buff = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    buff[i] += DINNER[dinner, i];
                }
                zakaz.Add(buff);
            }
            else zakaz.Add(null);
        }



        private float GetSale()
        {
            if (numberOfDays < 10) return 0;
            else return (numberOfDays % 10) / 100;
        }

        public float GetTotalPrice(Builder builder)
        {
            int totalPrice = 0;
            int size = builder.GetZakaz().Count;
            for (int i = 0; i < size; i++)
            {
                if (builder.GetZakaz()[i] != null)
                {
                    totalPrice += Convert.ToInt32(builder.GetZakaz()[i][1]);

                }
            }
            float percentOfSale = GetSale();


            return totalPrice-(float)totalPrice*percentOfSale;
        }

        public int GetTotalKkal(Builder builder)
        {
            int size = builder.GetZakaz().Count;

            int totalKkal = 0;
            for (int i = 0; i < size; i++)
            {
                if (builder.GetZakaz()[i] != null)
                {
                    totalKkal += Convert.ToInt32(builder.GetZakaz()[i][2]);

                }
            }
            return totalKkal;
        }
        

    }
}
