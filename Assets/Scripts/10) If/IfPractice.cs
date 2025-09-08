using UnityEngine;

public class IfPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 10;

        if (x == 10) Debug.Log("x는 10입니다.");

        if (x != 20) Debug.Log("x는 20이 아닙니다.");

        //문자열 비교
        string s1 = "Hello";
        string s2 = "Hello";

        if (s1 == s2) Debug.Log("Same");

        if (s1 != s2) Debug.Log("Different");  //거짓이므로 실행 안됨

        //부정
        bool bln = false;

        //!bln 값이 참이면 실행문을 실행
        if (!bln) Debug.Log("!bln: !false -> true");
        if (bln == false) Debug.Log("!bln: !false -> true");

    }
}
