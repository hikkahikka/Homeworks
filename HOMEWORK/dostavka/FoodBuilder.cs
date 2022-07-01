using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dostavka
{
    public class FoodBuilder :Builder
    {
        private Food foodBuilder;
        
        public override  void CreateZakaz()
        {
            foodBuilder = new Food();
            foodBuilder.zakaz = new List<string[]>();
        }

        public override void BuildBreakfast(int meal)
        {
            foodBuilder.SetBreakfast(meal);
        }

        public override void BuildSecondBreakfast(int meal)
        {
            foodBuilder.SetSecondBreakfast(meal);
        }
        public override void BuildLunch(int meal)
        {
            foodBuilder.SetLunch(meal);
        }
        public override void BuildSnack(int meal)
        {
            foodBuilder.SetSnack(meal);
        }
        public override void BuildDinner(int meal)
        {
            foodBuilder.SetDinner(meal);
        }
        public override List<string[]?>? GetZakaz()
        {
            return foodBuilder.zakaz;
        }

    }
}
