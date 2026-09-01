using UnityEngine;

public class Person : Animal
{

    // 절차지향 프로그래밍 vs 객체지향 프로그래밍 vs 함수형 프로그래밍

    // 절차지향 : 하나하나 차근차근 순서에 따라 프로그래밍
    // 객체지향 : 객체의 상호작용을 중심으로 프로그래밍

    // 게임이란 "가상 세계"에 존재하는 여러 "객체"의 "상호작용"을 "시뮬레이션"하고 그 결과를 "관찰"하는 것

    // [가상 세계] - 유니티 or 언리얼 상용 엔진 속 "씬"

    // [객체] - 현실 세상속의 대상 혹은 개념을 속성과 기능으로 추상화 한 것
    //          [오징어 게임의 사람이라는 객체]
    //          - 속성 : 상태, 데이터    // 죽었니 살았니 / 이름 / 나이 / 안경 유무 / 머리카락, 색깔, 키 등
    //          - 기능 : 행동           // 걷다, 뛰다 등
    //          - 추상화란 구체화의 반댓말로 복잡한 부분에서 필요한 것만 코드로 옮겨오는 것

    // [상호작용]  - 객체 간의 메세지(협력)
    //           - 유저의 입력
    //           - 물리

    // [시뮬레이션] - 시간에 따른 변화
    //            - 알고리즘(로직)

    // [관찰]      - 렌더링
    //            - 그래픽스(조명,쉐이더 등)

    // 이런 것들을 "하드 스킬"
    // 전투력 = 하드스킬 + 메타 스킬 + 소프트 스킬
    //
    // 하드 스킬: (엔진 * 2.5 + 문법 + 알고리즘 * 3 + 그래픽스 * 2) * AI의 생산성
    // 메타 스킬: 컴퓨터 구조 * 1 + 자료구조 * 2 + 설계(디자인 패턴/아키텍처) * 2 + 최적화 기법* 3
    // 소프트 스킬: 인성 + 대인관계 + 협력 + 기획력




    // 클래스 : 객체를 하나의 집합으로 묶는 단위
    
    // 필드 (속성, 멤버, 변수)
    // public : 외부에서 접근(읽기,쓰기)가 가능하다. - Name (파스칼)
    // private : 외부에서 접근이 불가능하다. - _name(_카멜)
    //                           지역변수 - name(카멜)
    // -> 접근 제한자(public,private,protected,internal)
    // 추상화,은닉화,캡슐화
    
    
    public bool HasGlasses = false;
    private int _age = 0;

    
    // 생성자 메서드
    // - 객체가 생성될 때 new 키워드와 함께 호출하는 메서드
    // - 클래스 이름과 같아야 한다.
    public Person(string name, int age, float height, float weight, bool HasGlasses)
    {
        int myFatherAge = 34;
        
        _name = name;
        _age = age;
        _height = height;
        _weight = weight;
        HasGlasses = false;
    }
    
    //기능 (메서드, 함수)
    public override void Introduce()
    {
        Debug.Log($"안녕하세요. 제 이름은 {_name}이고 나이는 {_age}입니다. 키와 몸무게는({_height}cm,{_weight}kg)입니다. 잘 부탁드립니다.");
    }
    

    // 메서드 오버로딩: 같은 이름의 메서드를 중복하여 여러개 만드는 것 
    // - 매개변수의 개수나 자료형이 달라야한다.
    
    
    public void SeatDown()
    {
        Debug.Log("땅바닥에 앉는다!");
    }

    public void SeatDown(Chair chair)
    {
        Debug.Log($"{chair.Color}에 앉는다.");
    }

    public void Punch(Person otherPerson)
    {

        string Name = "하하";
        // 철수가 찰스를 때렸다.
        Debug.Log($"{this._name}이가 {otherPerson._name}이를 때렸다!"); 
        // 변수 쉐도잉인 경우, 가까운 것을 찾아감(지역변수) 필드 변수가 필요할 때는 this.Name
        
    }
    
    
    
    

}