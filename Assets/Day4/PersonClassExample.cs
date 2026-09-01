using UnityEngine;

public class PersonClassExample : MonoBehaviour
{
    private void Start()
    {

        // 자료형 변수명 = 값
        // 클래스 클래스명 = new 클래스
        
        Chair chair1 = new Chair();
        chair1.Color = "푸른색";

        Person person1 = new Person("김철수", 18, 182.3f, 78, false);
        // 이름있는 매개변수 new Person(name: "김철수")

        // Debug.Log(person1.Name); // 현실에서는 불가능
        // person1.Name = "이철수"; // 현실에서는 불가능

        Debug.Log(person1.HasGlasses);
        
        
        person1.Introduce();
        person1.Run();
        person1.SeatDown(chair1);

        Person person2 = new Person("김찰스", 12, 177.3f, 55, true);

        person2.Introduce();
        person2.Run();
        person2.SeatDown();


        person1.Punch(person2);

        Person person3 = null; // 메모리 주소를 가리킬 변수만 만들었지 알맹이는 존재하지 않음.
        // null이란 존재하지 않는다는 뜻
        // 객체지향 프로그래밍에서 가장 빈번하게 오류를 일으키는 문법
        

        person1.Punch(person3);

    }
}