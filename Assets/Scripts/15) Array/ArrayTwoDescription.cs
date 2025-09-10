using UnityEngine;

public class ArrayTwoDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]2차열 배열 선언
        int[][] intArray = new int[2][];

        //[2] 두번째 요소수를 각각 따로 생성, 초기화intar
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 1, 2 };

        // 배열의 길이
        Debug.Log($"배열의 길이는 {intArray.Length}이다");              // 앞에 new에서 지정한 길이이다.

        //배열의 요소를 출력
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log($"intArray[{i}] : {intArray[i].Length}");

            //열의 길이 : intArray.GetLength(1)
            for (int j = 0; j < intArray.Length; j++)
            {
                Debug.Log($"intArray[{j}] : {intArray[j].Length}");
            }
        }

    }
}
