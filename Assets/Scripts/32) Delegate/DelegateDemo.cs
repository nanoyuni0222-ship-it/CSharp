using UnityEngine;

namespace Delegate
{

    public class DelegateDemo : MonoBehaviour
    {
        //[1] 델리게이트 정의, 생성 - Hi()를 대신 실행시키는 대리자
        //반환값도 없고, 매개변수도 없다
        //delegate 반환값 대리자이름 (매개변수)
        delegate void SayDelegate();


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Hi();       //안녕하세요

            //[2] 대리자 변수 선언 및 대신할 메서드 등록 1
            SayDelegate say = Hi;

            //[3] 델리게이트 실행(호출)
            say();  //안녕하세요

            //[4] 대리자 변수 선언 및 대신할 메서드 등록 2
            SayDelegate hello = new SayDelegate(Hello);
            //델리게이트 실행(호출)1
            Hello();                //안녕하세요

            // 대리자 변수 선언 및 대신할 메서드 등록
            SayDelegate insa = new SayDelegate(Hi);
            //델리게이트 실행(호출)2
            insa.Invoke();          //안녕하세요

        }



        void Hi()
        {
            Debug.Log("안녕하세요");
        }
        void Hello()
        {
            Debug.Log("Hello");
        }

    }
}




/*
클래스 멤버
: 필드(전역변수, 멤버변수), 생성자(소멸자), 메서드(함수, 멤버함수)
: 속성(Property), 인덱서(반복기), 델리게이트(대리자)

Delegate(대리자) : 매개변수 목록 및 반환 형식이 있는 메서드에 대한 참조를 나타내는 형식
                 : 대신 실행자, 등록(지정)한 매서드(들)를 대신 실행시켜주는 것

//형식 - 반환값이 없고, 배개변수 없는 함수를 대신 실행시켜주는 것
delegate void 대리자이름 ()

//생성한 델리게이트에 메서드를 등록 - 등록할 대상(대리자 변수) 필요



델리게이트 선언(생성) -> 생성한 델리게이트에 메서드를 등록 -> 델리게이트 실행
 
 
 */