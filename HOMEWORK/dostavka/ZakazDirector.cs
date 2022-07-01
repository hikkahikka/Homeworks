using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dostavka
{
    public class ZakazDirector
    {
        private Builder builder;
        
        public ZakazDirector(Builder _builder)
        {
            builder = _builder;
        }

        public void ConstructZakaz(int breakfast, int secondbreakfast, int lunch, int snack, int dinner)
        {
            
            builder.CreateZakaz();
            builder.BuildBreakfast(breakfast);
            builder.BuildSecondBreakfast(secondbreakfast);
            builder.BuildLunch(lunch);
            builder.BuildSnack(snack);
            builder.BuildDinner(dinner);
                    
        }
    }
}
