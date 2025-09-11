using UnityEngine;

public class MethodOverload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1234 출력, 정수형이 오든 실수형이 오든 상관없이 하나의 함수로 처리할 수 있음
        PrintNumber(1234);
        PrintNumber(1234f);
        PrintNumber(1234L);

    }

    //숫자를 출력하는 함수 만들기
    //int형 정수를 매개변수로 입력 받아 출력하는 함수

    void PrintNumber(int number) 
    {
        Debug.Log($"Int32 : {number}");
    }

    //float형 실수를 매개변수로 입력 받아 출력하는 함수
    void PrintNumber(float number)            //만약 float 자리에 int가 들어가면 위에 정수형과 같으므로 오류 발생
    {
        Debug.Log($"실수형 : {number}");
    }

    void PrintNumber(long number)
    {
        Debug.Log($"long64 : {number}");
    }
}

/*
MethodOverload : 함수의 다중 정의
: 동일한 이름의 메서드를 매개변수를 달리해서 여러개 생성(정의)
 */