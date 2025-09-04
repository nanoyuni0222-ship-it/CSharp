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

공백은 프로그램에서 무시 ex) UnityEngine.Debug.Log~ = UnityEngine.          Debug.         Log

회색 글자는 생략 가능(보통 위에서 지정해서 필요 없는 경우)

변수(Variable) : 프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇

프로그램은 만들고 저장하고 사용하는 순으로(변수 등) 

 */

