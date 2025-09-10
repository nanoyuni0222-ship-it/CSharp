using Unity.Burst.Intrinsics;
using UnityEngine;

public class ArrayTwoNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 2차원 배열 선언, 요소수(크기) 생성, 초기화
        // int[,] intArray = new int[2, 3] { {1,2,3}, {4,5,6} };  //콤마와 코드블록으로 행과 열을 구분
        // [1-2] 2차원 배열 선언, 요소수(크기) 생성 생략, 초기화
        // int[,] intArray = new int[,] { {1,2,3},{4,5,6} };         //데이터를 보고 열의 갯수 결정
        // [1-3] 2차원 배열 선언, 초기화
        int[,] intArray = { {1,2,3},{4,5,6} };

        Debug.Log($"배열의 길이는 {intArray.Length}이다");          // 3행2열인지 2행3열인지 볼 수 없음

        //출력 : 행의 길이 intArray.GetLength(0)
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            //열의 길이 : intArray.GetLength(1)
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log($"intArray[{i},{j}] : {intArray[i,j]}");
            }
        }

    }
}
