using UnityEngine;

public class WhileSum : MonoBehaviour
{
    public int n = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int sum = 0;

        //[1] 초기식
        int i = 1;

        while (i <= n)           //[2] 조건식
        {
            //반복 실행문
            //sum += 1;
            sum = sum + i;

            //[3] 증감식
            i++;
        }
        Debug.Log($"1~{n}까지의 합은 {sum}입니다.");*/

        int sum = 0;

        //[1] 초기식
        int i = 1;

        while (i <= n)           //[2] 조건식
        {
            //반복 실행문
            if (i % 2 == 0)
            {
                sum = sum + i;
            }
            i++;
         }
        Debug.Log($"1~{n}까지 짝수의 합은 {sum}입니다.");
    }
}

/*
[Q1]
while문을 이용해서 1부터 100(n)까지의 합을 구하는 프로그램 구현

[Q2]
while문을 이용해서 1부터 100(n)까지 짝수의 합을 구하는 프로그램 구현

//무한반복문
while(true)
{
        //반복실행문
}

 */
