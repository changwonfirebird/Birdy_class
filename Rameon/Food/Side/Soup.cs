using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Food_Tutorial.Food.Side
{
    internal class Soup
    {
        protected string type_name;
        protected string timing;

        private static string[] timingArray = new string[] { "선첨", "후첨" };

        public Soup(string type_name = "신라면 가루 스프", int timing_idx = 0)
        {
            this.type_name = type_name;
            this.timing = timingArray[timing_idx];
        }

        public override string ToString()
        {
            return "\t이름 : " + type_name + '\n' + "\t형식 : " + timing;
        }
    }
}
