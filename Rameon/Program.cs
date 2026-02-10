using Food_Tutorial.Food;
using Food_Tutorial.Food.Side;

namespace Food_Tutorial
{
    /*
     * 오버로딩 < 함수의 특성? 상태?
     * 생성자 오버로딩
     * 동일한 클래스, 상속관계에서 함수의 이름이 같으면
     * 오버로딩.
     * 단, 매개변수의 차이로 구분이 되어야 한다.
     * 개발자 시점에서도 구분지을 수 있다.
     * -> 컴파일러도 이미 알고 있다. 어떤 함수를 쓰는지.
     * -> 컴파일러 다형성
     * 다형성 : 동일하지만 다른거.
     * 오버라이딩
     * 상속관계에서의 함수의 이름이 같으면.
     * 
     * 
     * 오버라이딩.
     * 단, 모든것이 일치해야 된다. (접근지정자, 리턴타입, 매개변수, 함수명)
     * 원본(= 부모의 함수)이 존재한다. (부모껄 오버라이딩 한다.)
     * 1. 원본은 virtual 키워드를 사용한다.
     * 2. 사본(오버라이딩)은 override 키워드를 사용한다.
     * 재사용성이 향상. (국룰이 생기는것.)
     * 개발할때 1번 외우고 그거 계속 쓰면됨. -> 생산성이 향상.
     * 컴파일러가 알수 있을까? x
     * 실행하는 관점에서 이러한 변화를 알 수 있다.
     * -> 런타임에서 알게 된다.
     * -> 런타임 다형성.
     * 
     * 
     * 
     * 
     * 상속(얇게)
     * 모든 객체(class)는 Object가 부모이다, class는 Object를 상속한다. 
     * 
     * 
     * Rameon.getInfo(), Soup.showInfo(), Noodle.getType(), Label.showLabel(), Ingredient.getIngredient().... 클래스의 고유적인 함수 getInfo()
     * Object.ToString()를 오버라이딩.
     * 특별한 class. (부모가 되는 경우) (-> 나만의 국룰을 만듬.)
     * 
     * 디폴트 매개변수 (선택적 매개변수)
     * 매개변수(필수적 매개변수)와 다르게 함수 호출에서 생략 가능하다.
     * 단, 생략한 형식이 중복되는 오버로딩의 꼴이라면, 해당 오버로딩된 함수가 동작하게 된다.
     * 디폴트 매개변수는 가장 뒤에 있어야 한다.
     * 매개변수가 많을때, 그러나 모든 매개 변수가 개발자(사용자)가 굳이 설정할 이유가 없는 상황일때,
     * --> 생성자에서 애용하는 패턴.
     * 
     */



    internal class Program
    {
        static void Main(string[] args)
        {
            Rameon rameon = new Rameon();
            Console.WriteLine(rameon.ToString());
            //rameon.Cook();
            //Console.WriteLine(rameon.ToString());
            //rameon.SpecialCook(MySpecialRecipe);
            //Console.WriteLine(rameon.ToString());

            Ingredient ingredient = new Ingredient(name: "계란");
            Console.WriteLine(ingredient.ToString());

            Console.WriteLine(add(1, 2));
            Console.WriteLine(add(1, 2, 3));
            Console.WriteLine(add(1f, 2));

        }

        static Ingredient[] MySpecialRecipe()
        {
            return new Ingredient[]
            {
                new Ingredient("무가공", "파"),
                new Ingredient("무가공", "김치"),
                new Ingredient("무가공", "계란"),
                new Ingredient("무가공", "콩나물")
            };
        }

        private static int add(int a, int b)//add(int,int)
        {
            return a + b;
        }

        private static int add(int a, int b, int c)//add(int,int,int)
        {
            return a + b + c;
        }

        private static float add(float a, float b)//add(float,float)
        {
            return a + b;
        }







    }
}