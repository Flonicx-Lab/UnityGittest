using UnityEngine;

public class SwitchCaseExample : MonoBehaviour
{
    void Start()
    {
        // 분기문
        // 내가 원하는 값과 같냐 다르냐에 따라서 실행할 코드 분기를 나눌 수 있다.
        
        /**
         switch (검사할 변수)
         {
            case 값1:         //case 에는 값만 쓸 수 있다.
            {
                실행할 코드
                break;
            }
            
            case 값2:
            {
                실행할 코드...
                break;
            }
            
            default:        // (옵션, 아무런 case에 해당하지 않는다면...)
         }
         **/
        
        // 1번 문제
        DayOfWeek today = DayOfWeek.Thursday;

        switch (today)
        {
            case DayOfWeek.Monday:
            {
                Debug.Log("오늘은 월요일 입니다.");
            }
                break;

            case DayOfWeek.Tuesday:
            {
                Debug.Log("오늘은 화요일 입니다.");
            }
                break;
            case DayOfWeek.Wednesday:
            {
                Debug.Log("오늘은 수요일 입니다.");
                break;
            }
            case DayOfWeek.Thursday:
            {
                Debug.Log("오늘은 목요일 입니다.");
                break;
            }
            case DayOfWeek.Friday:
            {
                Debug.Log("오늘은 금요일 입니다.");
                break;
            }
            case DayOfWeek.Saturday:
            {
                Debug.Log("오늘은 토요일 입니다.");
                break;
            }
            case DayOfWeek.Sunday:
            {
                Debug.Log("오늘은 일요일 입니다.");
                break;
            }

    }


       int score = 98;
        
        switch (score / 10)
        {
            case 10:
            {
                Debug.Log("A+");
                break;
            }
                
            case 9:
                {
                Debug.Log("A");
                break;
                }
           
            case 8:
                {
                Debug.Log("B");
                break;
                }

            default:
            {
                Debug.Log("F");
                break;
            }
            }
                
                
                
        }
        
        
        
        
        
    }

