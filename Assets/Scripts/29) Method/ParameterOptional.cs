using UnityEngine;

namespace Method
{

    public class ParameterOptional : MonoBehaviour
    {
        //선택적 매개변수
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(3, 5));
            Debug.Log(Add(3));
        }

        //선택적 매개변수
        //매개변수로 받은 두개의 정수의 합을 반환하는 함수
        //함수 호출시 매개변수 b값은 생략가능하다, 생략하면 b값은 1(add에서 지정한 값)로 연산된다
        int Add(int a, int b = 2)
        {
            return a + b;
        }
    }
}