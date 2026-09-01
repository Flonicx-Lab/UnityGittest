using UnityEngine;

public class Array2DExample : MonoBehaviour
{
    private void Start()
    {
        // 2차언 배열 (다차원 배열)
        // 게임 개발에서 2차원 배열은 주로 타일 기반 게임에서 사용된다.
        // 사용 예시:
        // 3match 퍼즐 게임, 맵, 인벤토리, 체스
        // 표 형태의 데이터를 표현하는 데 많이 사용

        int[,] enemyHealths = new int[2, 3];
        enemyHealths[0, 0] = 31;
        enemyHealths[0, 1] = 28;
        enemyHealths[0, 2] = 45;
        enemyHealths[1, 0] = 10;
        enemyHealths[1, 1] = 56;
        enemyHealths[1, 2] = 68;

        Debug.Log(enemyHealths[1, 1]);

        for (int col = 0; col < enemyHealths.Length; col++)
        {
            for (int row = 0; row < enemyHealths.Length; row++)
            {
                Debug.Log($"enemyHealths[{col}][{row}]: {enemyHealths[col, row]}");

            }
        }

        // 윗 코드와 성능 차이가 있을까?
        // 있다. 배열은 그래서 행 우선으로 접근을 해야한다.
        // 캐시미스 발생을 줄이기 위해서 -> 캐시 히트
        for (int row = 0; row < enemyHealths.Length; row++)
        {
            for (int col = 0; col < enemyHealths.Length; col++)
            {
                Debug.Log($"enemyHealths[{row}][{col}]: {enemyHealths[row, col]}");

            }
        }





    }

}    