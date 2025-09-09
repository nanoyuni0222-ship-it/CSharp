using UnityEngine;

public class DoWhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요를 3번 반복 출력하는 프로그램 구현

        //for문
        /*for (int i = 0; i < 3; i++) 
        {
            Debug.Log("안녕하세요");
        }

        //while문
        //초기식
        int i = 0;

        while (i < 3)           //조건식이 참이면 반복문 실행, 거짓이면 while문 종료
        {
            i = ++i;
            Debug.Log("안녕하세요");*/

        //do while문
        
        /*int i = 0;
        do 
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //증감식
            i++;

        } while (i < 3);

        //초기식 i = 0 -> "안녕하세요" -> i=1 -> i < 3 -> "안녕하세요" -> i = 2 -> i < 3 -> "안녕하세요" -> i = 3 -> i < 3 -> 프로그램 종료*/


    }
}

/*

//do while 조건문

//선행적으로 반복 실행문 실행
// 그 후 조건식을 판별하여 참이면 반속 실행문 실행, 거짓이면 while문 종료
//따라서 do while은 조건과 상관없이 1회는 무조건 실행한다

do
{
        //반복실행문

} while(조건식)
 */