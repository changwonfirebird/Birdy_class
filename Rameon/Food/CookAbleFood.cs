using Food_Tutorial.Food.Side;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Tutorial.Food
{
    internal class CookAbleFood
    {
        protected bool isCooked = false;

        public void Cook()
        {
            isCooked = true;
        }

        public virtual void SpecialCook(Func<Ingredient[]> func)
        {
            isCooked = true;
            //복잡 - 아무튼 복잡
        }
    }
}
