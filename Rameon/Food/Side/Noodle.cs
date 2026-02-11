using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Food_Tutorial.Food.Side
{
    internal class Noodle
    {
        protected string type_name;

        private static string[] typeArray = new string[] { "일반면", "두꺼운면", "얇은면", "칼국수면", "쌀국수면" };

        public Noodle(int type_idx = 0)
        {
            this.type_name = typeArray[type_idx];
        }

        public override string ToString()
        {
            return "면 : " + type_name;
        }
    }
}
