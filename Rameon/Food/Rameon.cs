using Food_Tutorial.Food.Side;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Food_Tutorial.Food
{
    internal class Rameon
    {
        protected Label label;
        protected Soup[] soups;
        protected Ingredient[] ingredients;
        protected Noodle noodle;

        protected bool isCooked = false;

        public Rameon(Label label, Soup[] soups, Ingredient[] ingredients, Noodle noodle)
        {
            this.label = label;
            this.soups = soups;
            this.ingredients = ingredients;
            this.noodle = noodle;
        }


        //this(new Label(), [new Soup()], [new Ingredient()], new Noodle()) 
        // temp01 = new Label()
        // temp02 = [new Soup()]
        // ...
        // this(temp01, temp02, temp03, temp04)
        public Rameon() : this(new Label(), [new Soup()], [new Ingredient()], new Noodle()) 
        {}

        public override string ToString()
        {
            string soupInfo = "";
            string ingredientInfo = "";

            for (int i = 0; i < soups.Length; i++) 
            {
                soupInfo += soups[i].ToString() + '\n';
            }
            
            for (int i = 0;i < ingredients.Length; i++) 
            {
                ingredientInfo += ingredients[i].ToString() + '\n';
            }

            return label.ToString() + '\n' +
                "스프(" + soups.Length + ") : \n" + soupInfo + 
                "건더기(" + ingredients.Length + ") : \n" + ingredientInfo +
                noodle.ToString() + '\n' +
                "상태 : " + (isCooked ? "조리됨" : "조리안됨");
        }

        public void Cook()
        {
            isCooked = true;
        }

        public void SpecialCook(Func<Ingredient[]> func)
        {
            Ingredient[] add = func();
            int count = ingredients.Length + add.Length;

            Ingredient[] new_ingredients = new Ingredient[count];
            for (int i = 0; i < ingredients.Length; i++)
            {
                new_ingredients[i] = ingredients[i];
            }
            for (int i = 0; i < add.Length; i++)
            {
                new_ingredients[ingredients.Length + i] = add[i];
            }

            ingredients = new_ingredients;
            isCooked = true;
        }

    }
}
