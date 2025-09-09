using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    //정수형 변수 선언 및 초기화
    public int a = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //입력 받은 수가 짝수이면 "{a}는 짝수" 출력
        //if문 짝수 판별식
        if (a == 0) Debug.Log($"{a}는 0");
        else if (a % 2 == 0) Debug.Log($"{a}는 짝수");
        else Debug.Log($"{a}는 홀수");

        //입력 받은 수가 홀수이면"{a}는 홀수", "아니면 "{a}는 짝수"라고 출력
        // if else문으로 홀,짝수 판별
        /* if (a % 2 != 0) Debug.Log($"{a}는 홀수");
         else Debug.Log($"{a}는 짝수");*/

        //입력 받은 수
        //3의 배수, 5의 배수, 7의 배수 판별식 만들기 : {a}는 3의 배수, {a}는 5의 배수, {a}는 7배수
        // 아니면 {a}는 3,5,7의 배수가 아니다 출력
        switch (a)
        {case 0:
                Debug.Log($"{a}는 0");
                break;
        default:
            if (a % 3 == 0) Debug.Log($"{a}는 3의 배수");
            if (a % 5 == 0) Debug.Log($"{a}는 5의 배수");
            if (a % 7 == 0) Debug.Log($"{a}는 7의 배수");
            if (a % 3 != 0 && a % 5 !=0 && a % 7 !=0) Debug.Log($"{a}는 3, 5, 7의 배수가 아니다");
                break;
        }
    }

}
