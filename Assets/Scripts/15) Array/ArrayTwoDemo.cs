using UnityEditor.Rendering;
using UnityEngine;

// 2차원 배열 : 행과 열로 이루어진 배열 , 이중 for문으로 돌리는것이 정확
// (데이터 타입)[,] 배열의 이름     ; 행과 열이 들어가야하므로 []안에 ','
public class ArrayTwoDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 배열 선언
        int[,] intArray;

        // [2] 배열 요소수(크기) 생성
        intArray = new int[2, 3];

        // [3] 배열 초기화
        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;

        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;

        // 배열 사용
        for (int i = 0; i < 2; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Debug.Log(intArray[i,j]);
            }
            Debug.Log("=======================");
        }
        
    }
}
