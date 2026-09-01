using Day5;
using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    // 다형성 (Polymorphism)
    // 하나의 객체가 여러 타입(자료형)을 가질 수 있는 성질
    // 즉 강아지는 강아지이자 동물 타입
    
    
    private void Start()
    {
        Animal person1 = new Person("김철수", 26,179f,55,false);
        Animal cat1 = new Cat("삠삐", 30, 10);

        Animal person2 = new Person("조조", 21, 180f, 60, false);
        Dog dog1 = new Dog("누리", 50, 15);

        Animal person3 = new Person("제갈량", 15, 178f, 55, false);
        Dog dog2 = new Dog("덕자", 44, 12);

        Animal person4 = new Person("육손", 14, 188f, 45, false);
        GoldFish fish1 = new GoldFish("금", "빨간색");
        GoldFish fish2 = new GoldFish("붕", "하얀색");
        
        // 자료형[] 변수명 = new 자료형[크기] { 초기값 }
        // 클래스도 자료형이고 참조 타입이며 사용자 정의 자료형이라고 하기도 한다.
        Animal[] animals = new Animal[] {person1, cat1, person2, dog1, dog2, person3,person4,fish1,fish2};
        foreach (Animal animal in animals)
        {
            animal.Introduce();

            if (animals is Person) // is: 객체가 실제로 해당 타입인지 검사한 후 그 결과를 bool형태로 반환
            {
                // 1. 명시적 형변환
                Person person = (Person)animal;
                person.SeatDown();

            }
            

            // 2. as 형변환: 형변환을 시도해서 성공하면 성공 실패하면 null 반환
            Person pperson = animal as Person;
            if (pperson != null) // null인지 아닌지로 사람인지 아닌지 판단가능
            {
                pperson.SeatDown();
            }
        }

    }


}
