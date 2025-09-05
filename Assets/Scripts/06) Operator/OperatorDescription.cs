using UnityEngine;

// Operator(연산자) : +, -, *, / 등 연산을 진행하는 키워드
public class OperatorDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* Debug.Log(3 + 5);
         Debug.Log(3 - 5);
         Debug.Log(3 * 5);
         Debug.Log(3 / 5);   // (정수)/(정수)는 정수가 나오고 (정수)/(실수)는 실수가 나옴 => 데이터 타입이 큰 것으로 나옴
                             // (정수)+(문자열)은 문자열이 나옴*/

        /*int value = 0;

        value = 8;  //value 변수에 8 저장
        value = +value; // 
        Debug.Log(value);

        value = -8;
        value = +value;
        Debug.Log(value);

        value = 8;
        value = -value;
        Debug.Log(value);

        value = -8;
        value = -value;
        Debug.Log(value);*/

        int i = 5;
        int j = 3;
        int k;
        
        k = i + j;
        Debug.Log(k);

        k = i - j;
        Debug.Log(k);

        k = i * j;
        Debug.Log(k);
        
        k = i / j;
        Debug.Log(k);

        k = i % j;  // 나머지를 구하는 연산자
        Debug.Log(k);  

    }


}
