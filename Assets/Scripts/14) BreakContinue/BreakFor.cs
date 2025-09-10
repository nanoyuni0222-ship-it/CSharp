using UnityEngine;

//break;        : 반복문(for, while){} 을 빠져나오는 명령문
//              : 반복문(for, while)을 강제 종료 시킨다
public class BreakFor : MonoBehaviour
{
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //5번 반복하는 for문 작성 - i가 2일때 for문 종료
        /*for (int i =0 ; i<n; i++)
        {
            //반복 실행문1
            Debug.Log(i);

            if(i == 2) {break;}
        }*/

        //   => 반복 실행문 3번 시행

        for (int i = 0; i < n; i++)
        {
            //반복 실행문1
            Debug.Log(i);

            if (i == 2) { break; }
            //반복 실행문1
        }

        //   -> 반복 실행문 2번 시행

    }

    //명령문 2
}
