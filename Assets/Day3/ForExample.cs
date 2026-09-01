using UnityEngine;

public class ForExample : MonoBehaviour
{
    void Start()
    {
        // 반복문: 설정한 조건이 참일 동안(거짓이 될 때 까지) 코드 블록 내부를 반복해서 실행한다.
        
        // For 반복문
        /**
          for (초기식, 조건식, 증감연산자)
          {
               반복할 코드들
          }
         // 초기식 : 처음 한 번 실행할 식(보통 변수의 선언) : ex. int i = 0;
         // 조건식 : 값을 비교해서 결과를 참/거짓 판명해주는 연산자
         // 증감 연산자 : ex. i++
        **/

        for (int i = 0; i < 1000; i++)
        {
            Debug.Log($"안녕하세요.{i:4d}");
        }
        
        // 1. 1부터 1000까지 짝수만 더한 값.
        
        int result1 = 0;
        for (int i = 0; i < 1001; i++)
        {
            if (i % 2 == 0)
            {
                result1 += i;
            }
        }
        
        // 2. 구구단 2단 ~ 9단까지
        // 점프문: 반복문 내부에서 흐름을 끊고 코드 시행 위치를 원하는 곳으로 점프해준다.
        // - break;    : 현재 실행중인 반복문이나 분기문에 실행을 중단할 때 사용 (종료/탈출 이라고 부르기도 함)
        // - continue; : 반복문 코드 블록 내에서 현재 실행중인 코드 라인의 아래 코드들의 실행을 건너 뛸 때 사용
        int result2 = 0;
        for (int i = 2; i < 10; i++)
        {
            if (i == 5) // 5단 스킵
            {
                continue;
            }
            Debug.Log($"{i}단 시작!");
            for (int j = 1; j < 10; j++)
            {
                result2 = i * j;
                Debug.Log($"{i}*{j}는 {result2:D2}입니다.");
            }
        }
        
        
    }

}