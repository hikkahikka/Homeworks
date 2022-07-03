using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dostavka
{
    /// <summary>
    /// абстрактный класс строителя, содержит части по которым будет делаться итоговый продукт
    /// </summary>
     public  abstract class Builder
    {

        public abstract void CreateZakaz();

        
        public abstract void BuildBreakfast(int meal);
        public abstract void BuildSecondBreakfast(int meal);
        public abstract void BuildLunch(int meal);
        public abstract void BuildSnack(int meal);
        public abstract void BuildDinner(int meal);


        public abstract List<string[]?>? GetZakaz();
    }
}
