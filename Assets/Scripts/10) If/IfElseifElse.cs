using UnityEngine;

// ElseIf문
// 두 개의 정수 number1, number2를 입력받아
// [1] number1이 크면 number1이 큽니다 출력
// [2] number2이 크면 number2이 큽니다 출력
// [3] number1=number2이면 두 수의 크기가 같습니다 출력
public class IfElseifElse : MonoBehaviour
{
    public int number1 = 0;
    public int number2 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (number1 > number2) Debug.Log($"{number1}이 큽니다");
        else if (number1 < number2) Debug.Log($"{number2}이 큽니다");
        else Debug.Log("두 수의 크기가 같습니다");
        Debug.Log("종료");

    }
}

/*

 */