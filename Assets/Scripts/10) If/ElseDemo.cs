using UnityEngine;

// else문
public class ElseDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*if (1 < 1) Debug.Log("조건식이 참이면 실행문1을 실행한다.");
        else if (1==1) Debug.Log("조건식이 거짓이면 실행문2를 실행한다.");*/
    }
}


/*
else문 : 아니면
if 조건식이 참일때면 else의 실행문2는 실행하지 않는다(실행문 1 실행)
if 조건식이 거짓일때면 else 실행문2를 실행한다(실행문 1 실행x)

if(조건식)
{
     //실행문1
}
else                 //else는 if문의 실행문이 끝나는 곳에
{
     //실행문2
}

// 실행문3

1. 조건식이 참일 경우 => 실행문 1,3 실행
2. 조건식이 거짓일 경우 => 실행문 2,3 실행


 */