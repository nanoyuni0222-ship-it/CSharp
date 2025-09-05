using UnityEngine;

public class ConstantNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 선언 및 초기화
        string name = "홍길동";
        name = "이순신";  //수정가능

        //상수 선언 및 초기화
        const int AGE = 20;  //age 20으로 고정
        //AGE = AGE + 1;       //age 수정시 에러 발생
                             

        //사용
        Debug.Log($"{name} - {AGE}");







    }
}
