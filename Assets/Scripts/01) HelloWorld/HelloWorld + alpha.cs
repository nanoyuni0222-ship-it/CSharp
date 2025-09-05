//[1] 네임스페이스 선언부

using UnityEngine;//현재 cs 파일에서 유니티 엔진 네임스페이스를 사용

//[2]클래스 선언부
public class HelloWorld : MonoBehaviour// 네임스페이스 선언에서 유니티 엔진 사용 안하고 UnityEngine.~을 통해서도 오류 없이 사용 가능
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //[3] start 매서드 선언 : 프로그램을 시작할 때 1번만 실행
    void Start()
    {

        //[5]출력 명령문, 스크립트 명령어 위치 중요
        Debug.Log("Hello CSharp!");

    }

    // Update is called once per frame
    //[4] Update 매서드 선언 : 프로그램 시작 후 매 프레임마다 실행
    void Update()
    {
        
    }
}


// 한 줄 주석 :설명문

// 여러줄 주석  /* ~ */
/* 
콘솔창에 아래 내용을 출력하세요 => [output]  

C# Syntax(문법) : 반드시 지켜야하는 규칙
코딩스타일 : 프로그램 작성에 대한 가이드 라인, 개발자들간의 암묵적 약속 -> ex) 줄마다 주석 달기, 들여쓰기(Indent) : 공백 4칸 or 탭
제일 먼저 변수 이름을 보며 어떤 프로그램을 짜려고 하는지 파악함 => 네이밍 센스 필요

공백은 프로그램에서 무시 ex) UnityEngine.Debug.Log~ = UnityEngine.          Debug.         Log

회색 글자는 생략 가능(보통 위에서 지정해서 필요 없는 경우)

변수(Variable) : 프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇
변수 선언 - 앞에 데이터 타입을 쓰고 뒤에 변수 이름 지정(오른쪽 값을 왼쪽에 저장)

프로그램은 만들고 저장하고 사용하는 순으로(변수 등) 

클래스 이름 : 첫 알파벳 글자는 대문자, 단어와 단어 연결시 다음 단어의 첫글자는 대문자
변수 이름 : 첫 알파벳 글자는 소문자, 단어와 단어 연결시 처음 단어만 첫 글자가 소문자고 다음 단어의 첫글자는 대문자
상수 이름 : 모두 대문자

단항 연산자 : +, -
이항 연산자 : +, -, *, /, %   프로그램에서 % 활용도가 높음, %는 나머지를 구하는 연산자
삼항 연산자 : 

 */

