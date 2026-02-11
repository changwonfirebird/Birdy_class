using Food_Tutorial.Food;
using Food_Tutorial.Food.Side;

namespace Food_Tutorial
{
    /*
     * 
     * static
     * OOP...
     * 객체(instance) vs 클래스(class)
     * 클래스 (정적)가 
     * 객체 (동적)를
     * 생성.
     * 생산성, 유지보수... 좋게 할려고
     * 
     * 객체를 만들기 전에 class -> 멤버 요소(변수/함수(메서드))를 쓸 수는 없는가?
     * 
     * static 키워드
     * = 정적
     * 
     * 
     * this?
     * - 생성된 인스턴스 나 자신
     * 
     * 
     * 
     * class 하위의 요소들. (변수, 함수)
     * - 객체를 생성하지 않아도 해당 요소에 접근이 가능한다.
     * - 객체와 상관없는 요소이다.
     * - 객체가 없어도 해당 static 키워드가 붙은 요소는 접근할 수 있다.
     * - 객체는 static을 접근할 수 있는가? -> 접근할 수 있다.
     *   - class 내부 코드에선 this로 접근하지 않아야 한다. (그냥 써서 접근한다.)
     *   
     * - static 메서드가 this를 사용할 수 있는가? -> 사용할 수 없다.
     * 
     * 접근 여부
     * this -> this (o)
     * this -> static (o)
     * static -> this (x)
     * static -> static (o)
     * 
     * static 
     * 객체만 가지는게 아닌거. 모두가 공용인거 (변수가 static -> 글로벌 변수.)
     * 함수가 static -> 글로벌 함수.
     * 표지판(클래스명.)
     * 
     * 
     * 
     * 상속 
     * 부모가 가진 멤버 함수, 멤버 변수 -> 자식도 가지는거. (유전)
     * A.t
     * B : A
     * B.t
     * 
     * base? (this 확장판)-> base(1) 부모의 생성자를 지정할 수도 있다.
     * 생성된 객체 나 자신(부모).
     * 
     * 
     */



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rameon.GetCount());
            for (int i = 0; i < 10; i++) 
            {
                CookAbleFood temp = new Rameon();
            }
            Console.WriteLine(Rameon.GetCount());
        }
    }
}