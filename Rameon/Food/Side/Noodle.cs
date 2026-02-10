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

        public Noodle(string type_name = "일반면")
        {
            this.type_name = type_name;
        }

        public override string ToString()
        {
            return "면 : " + type_name;
        }
    }
}
