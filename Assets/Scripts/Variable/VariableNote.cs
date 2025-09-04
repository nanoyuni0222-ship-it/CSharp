using UnityEngine;

public class VariableNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 만들기(선언)
        int i; // 'i'라는 이름으로 (정수형) 변수 만들기

        //[2]변수에 값을 저장하기(=대입, 할당, 초기화; 초기화는 변수를 선언하고 가장 먼저 값을 담을 때를 초기화라고 함)
        i = 1234;

        //[3] 변수에 들어있는 값을 사용하기(=참조)
        Debug.Log(i); // i에 들어있는 값을 출력

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
