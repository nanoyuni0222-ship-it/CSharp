using UnityEngine;

//불(bool) 데이터 타입 : 논리 자료형, 참(True) 또는 거짓(False) 값만 저장
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool형 변수 선언 및 초기화
        bool bin = true;
        bool isOut = false; //bool형 할때 많은 개발자들이 변수명 앞에 is를 많이 붙임(참 거짓이기 때문)

        //[2] 사용하기
        Debug.Log("bin:" + bin);
        Debug.Log("isOut:" + isOut);
    }
}
