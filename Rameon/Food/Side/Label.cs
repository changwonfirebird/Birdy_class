using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Food_Tutorial.Food.Side
{
    internal class Label
    {
        protected string manufacturer_name;
        protected string product_name;

        public Label(string manufacturer_name = "농심", string product_name = "신라면")
        {
            this.manufacturer_name = manufacturer_name;
            this.product_name = product_name;
        }

        public override string ToString()
        {
            return "제조사 : " + manufacturer_name + '\n' + "제품명 : " + product_name;
        }
    }
}
