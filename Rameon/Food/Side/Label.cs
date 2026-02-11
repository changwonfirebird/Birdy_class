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

        private static string[] manufacturerArray = new string[] { "농심", "삼양", "오뚜기", "하림" };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturer_idx">0: 농심 1: 삼양 2: 오뚜기 3: 하림</param>
        /// <param name="product_name"></param>
        public Label(int manufacturer_idx = 0, string product_name = "신라면")
        {
            this.manufacturer_name = manufacturerArray[manufacturer_idx];
            this.product_name = product_name;
        }

        public override string ToString()
        {
            return "제조사 : " + manufacturer_name + '\n' + "제품명 : " + product_name;
        }
    }
}
