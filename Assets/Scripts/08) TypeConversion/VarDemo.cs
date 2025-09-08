using UnityEngine;

// var : 암시적으로 형식화된 로컬 변수, 로컬 변수는 함수 안에서 선언되는 변수를 말함, var은 함수 안에서만 사용 가능
public class VarDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* int i = 1234;                    //정수
        string s = "안녕하세요";            //문자열
        char c = 'a';                       //문자
        double d = 3.14;                    //실수

        // 어떤 타입인지 알 수 있는 방법
        Debug.Log(i.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
        Debug.Log(d.GetType());  */

        var name = "홍길동";     // "홍길동" 값을 보고 name 변수의 타입을 string으로 결정
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 8.0;       // 8.0 값을 보고 version 변수의 타입을 double형으로 결정
        Debug.Log(version); 
        Debug.Log(version.GetType());

        var number = 1;          // 1 값을 보고 number 변수의 타입을 int형으로 결정
        Debug.Log(number);
        Debug.Log(number.GetType());

        var Fact = true;        // true 값을 보고 Fact 변수의 타입을 bool형으로 결정
        Debug.Log(Fact);
        Debug.Log(Fact.GetType());

        var one = 'ㅎ';         // 'ㅎ' 값을 보고 one 변수의 타입을 char으로 결정
        Debug.Log(one);
        Debug.Log(one.GetType());

    }
}
