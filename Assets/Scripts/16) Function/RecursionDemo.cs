using UnityEngine;

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4!
        Debug.Log(4 * 3 * 2 * 1);

        //
        Debug.Log(Factorial(4));
        
        //
        Debug.Log(FactorialFor(4));

        //
        Debug.Log(Factor(4));



        //매개변수로 받은 n값의 팩토리얼 구하는 알고리즘 구현    
        int Factorial(int n)
        {
            //종료 조건
            if (n == 1) return 1;


            //재귀 호출부
            return n * Factorial(n - 1);
        }

        //3항 연산자를 이용한 Factorial
        int Factor(int n)
        {
            return (n > 1) ? n * Factor(n - 1) : 1;
        }

        //for문 이용
        int FactorialFor(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}
        

/*
재귀함수 : 재귀 호출이 있는 함수
재귀호출 : 함수가 자신의 코드블록 안에서 자기 자신을 다시 호출
재귀함수는 매개변수를 가지고 있다
매개변수는 감산을 하거나 가산을 한다
재귀함수의 코드 블록안에는 종료할 수 있는 조건이 필요하다

- 종료 조건 처리부
- 재귀 호출부
*/
