using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 Countdown 프로그램 구현
        //[1]초기식
        int i = 1;

        while (i <= 5)          //[2]조건식 
        {
            Debug.Log($"증가 카운트다운 : {i}");        //반복 실행문
            i++;                                   //증감식
        }

        //5부터 1까지 Countdown 프로그램 구현
        int j = 5;

        while (j>=1)          //[2]조건식 
        {
            Debug.Log($"감소 카운트다운 : {j}");        //반복 실행문
            j--;                                        //증감식
        }
    }
}