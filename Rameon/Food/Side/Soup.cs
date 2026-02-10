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

        public Soup(string type_name = "신라면 가루 스프", string timing = "선첨")
        {
            this.type_name = type_name;
            this.timing = timing;
        }

        public override string ToString()
        {
            return "\t이름 : " + type_name + '\n' + "\t형식 : " + timing;
        }
    }
}
