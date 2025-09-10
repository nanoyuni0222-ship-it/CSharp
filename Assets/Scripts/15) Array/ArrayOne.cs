using UnityEngine;

// 1차원 배열, 2차원 배열, 3차원 배열 ; 대부분의 프로그램은 1차원 배열 사용
public class ArrayOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 1차원 배열
        int[] intArray;

        // [2] 1차원 배열 요소수 생성, 크기 결정, 메모리 영역 확보
        intArray = new int[3];  //[0], [1], [2]

        // [3] 배열 초기화
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;

        // [4] 배열의 사용
        /*for (int i = 0; i < 3; i++) 
        {
            //Debug.Log($"{i}번째 방의 값은 {intArray[i]}");
            Debug.Log($"{i}번째 index의 값은 {intArray[i]}");
        }*/

        int i = 0;

        foreach (int num in intArray) 
        {
            // 반복 실행문
            Debug.Log($"{i}번째 index의 값은 {num}");
            
            // 증가식
            i++;    
        }

    }
}

/*
foreach(배열변수 데이터타입  in 배열변수 )
{
    //반복 실행문
}
 */
















