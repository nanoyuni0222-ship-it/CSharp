using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

// 만약 score가 60 이상이면 "합격"이라고 출력
public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        /*  
         int score = 60;

        // 조건식이 참이면 코드블록 안에 있는 실행문을 실행
        if (score >= 60)
        {
            Debug.Log("합격");
        } */

        // 실행문이 단문(1개)인 경우
        if (1 == 1)
        {
            Debug.Log("단문 1");
        }

        // if문에서 {}이 생략되면 if문 바로 밑에 있는 명령문을 참일때 실행한다
        // if문 바로 밑에 있는 명령문 하나만 if문 실행문이 된다
        if (1 == 1)
            Debug.Log("단문 2");

        // 옆에 붙이는 것도 가능
        if (1 == 1) Debug.Log("단문 3");


        // 실행문이 복문(2개 이상)인 경우


        //복문(실행문 2개 이상), 복문이면 무조건 코드블록이 있어야함
        if (1 == 1)
            Debug.Log("복문 1");
            Debug.Log("복문 2");


    }
}

/*
If문(조건문 중 하나)
조건식이 참일때만 실행문이 실행된다
조건식이 거짓이면 실행문을 실행하지 않는다.

만약 조건식이 참이면 {}내의 실행문을 실행하라
if(조건식)             
{
      실행문 1
      실행문 2 
        ...
}


if( bool )
{
      실행문 1
      실행문 2 
        ...
}


 */