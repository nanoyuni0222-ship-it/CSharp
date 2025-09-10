using UnityEngine;

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //크기가 3인 정수형 배열을 선언하고 초기화
        int[] numbers = { 1, 2, 3 };

        //배열의 인덱스를 관리하는 변수를 0으로 초기화(0, 1, 2)
        int index = 0;

        Debug.Log(numbers[index++]);        
        Debug.Log(numbers[index++]);        
        Debug.Log(numbers[index++]);        

        Debug.Log(numbers[--index]);        
        Debug.Log(numbers[--index]);        
        Debug.Log(numbers[--index]);        

    }
}
