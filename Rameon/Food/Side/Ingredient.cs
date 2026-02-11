using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Tutorial.Food.Side
{
    internal class Ingredient
    {
        //C#. 국룰.. 변수명이 대문자로 시작한다. = 해당 변수 public 
        //변수명이 소문자로 시작한다 = 외부접근 불가능 (private, protected, internal)
        //모든 문자가 대문자다 = 상수.(읽기만 가능하다.)
        protected string status;//동결건조, 건조, 살균포장
        protected string name;

        private static string[] statusArray = new string[] { "동결건조", "건조", "진공", "기타" };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status_idx">0 : 동결건조 1 : 건조 2: 진공 3 : 기타</param>
        /// <param name="name"></param>
        public Ingredient(int status_idx = 0, string name = "파")
        {
            this.status = statusArray[status_idx];
            this.name = name;
        }

        public override string ToString()
        {
            return "\t상태 : " + status + '\n' + "\t재료명 : " + name;
        }
    }
}
