using UnityEngine;

// + 더하기 연산 추가 기능
public class AdditionalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello"+"World");  // 문자열 더하기

        Debug.Log("123" + "456");    // 문자열 + 문자열

        Debug.Log("123" + 456);      //문자열 + 숫자 : 문자열

        Debug.Log(123 + 456);        //숫자 + 숫자 : 산술연산

        Debug.Log(123 + "456");      //숫자 + 문자열 : 문자열

        Debug.Log("123" + true);     //문자열 + bool : 문자열

        Debug.Log(true + "456");     //bool + 문자열 : 문자열

        Debug.Log(123 + "456" + 789 + 890);   // 앞에서부터 순차적 계산

        Debug.Log(123 + 456 + "789" + 890);   // 앞에서부터 순차적 계산

        //Debug.Log(123 + true);     숫자 + bool은 안됨
        //Debug.Log(123 - "456");    빼기는 없음
    }
}
