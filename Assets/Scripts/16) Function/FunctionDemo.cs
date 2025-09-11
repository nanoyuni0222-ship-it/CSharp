using UnityEngine;

public class FunctionDemo : MonoBehaviour
{
    //[1] Show 매서드(함수)선언, 정의
    //함수가 어떤 기능을 하는지 주석 달기 ; 콘솔창에 Hello World를 출력하는 함수
    void Show()
    {
        Debug.Log("Hello World");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()            //반환값, 매개변수가 없는 함수
    {
        //[2] Show() 함수 호출
        Show();
        
    }
}

/*
함수(Function), 매서드(Method)                 함수는 클래스 코드블록 안에서 만들고 다른 함수 안에 새로운 함수를 만드는 일은 잘 하지 않는다.
: 반복해서 사용하도록 만들어진 하나 이상의 명령문으로 구성된 코드블록{}
- 내장함수 : 닷넷(c#), 유니티에서 제공하는 함수

- 사용자 함수 : 개발자가 만드는 함수
1) 매개변수가 없는 함수

void 함수이름()
{
    //하나 이상의 명령문
}

2) 매개변수가 있는 함수

void 함수이름(매개변수)
{
    //하나 이상의 명령문
}

3) 반환값이 있는 함수

(데이터 타입) 함수이름(매개변수)
{
    //하나 이상의 명령문

    return (데이터 타입)변수;
}
 
// 4) 반환값이 없는 함수)

// 함수구성
입력 -> 처리(연산) -> 출력

 */