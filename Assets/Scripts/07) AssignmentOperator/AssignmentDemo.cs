using UnityEditor.Build;
using UnityEditor.Rendering;
using UnityEngine;

//할당(대입) 연산자 (=) : 변수에 값을 저장
public class AssignmentDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*string name = "홍길동";
        int age = 19;
        Debug.Log($"이름은 {name}, 나이는 {age}"); */

        //Swap 연산
        //변수 선인 및 초기화
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"처음값 i:{i}, j:{j}");

        temp = i;
        i = j;
        j = temp;     
        
        Debug.Log($"나중값 i: {i}, j:{j}");   //Q. 그냥 i랑 j를 바꾼 것이랑 값이 똑같음  => 변수 지정 안할시 값이 손상될 수 있음1
    }
}



/*
Q. +,- 등 다른 연산 없이 변수 i와 j의 값을 서로 바꾸어서 저장하세요
Hint) temp 변수를 만들어서 이용하세요

[output]
처음값 i : 100, j : 200
나중값 i : 200, j : 100
*/