using UnityEngine;

public class StringParseExample : MonoBehaviour
{
    void Start()
    {   
        // 문자열을 int로 변환
        string stringAge = "38";
        int intAge = 0; // 이미 변수선언이 되어있어야 변환
        bool result1 = int.TryParse(stringAge, out intAge); //bool로 체크 , out 으로 값도 바뀜
        if (result1 == true)
        {
            Debug.Log(intAge);
        }
        else
        {
            Debug.Log("변환에 실패했습니다.");
        }
        
        // float => 문자열
        float floatHeight = 174f;
        string stringHeight = floatHeight.ToString();
      
        // 문자열을 float로 변환
        string stringWeight = "70.2kg";
        float floatWeight = 0f;
        bool result2 = float.TryParse(stringWeight, out floatWeight);
        if (result2 == true)
        {
            Debug.Log(floatWeight);
        }
        else
        {
            Debug.Log("변환에 실패했습니다.");
        }
        
    }
}