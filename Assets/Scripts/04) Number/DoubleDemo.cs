using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 선언 및 초기화
        float f = 3.14f; //실수형 literal은 문법상 뒤에 f가 붙어야함   Q. 대문자F를 써도 문제없이 출력됨 => literal의 타입을 지정하는 접미사는 대소문자 구분x
        double d = 3.14;  //d를 생략해도 실수형 중에 더블형이라고 인식함  
        decimal m = 3.14m; 

        //[2] 변수 사용
        Debug.Log(f);
        Debug.Log(d);
        Debug.Log(m);

        float min = float.MinValue;
        float max = float.MaxValue;

        Debug.Log(min);
        Debug.Log(max);
    }
}

/*
 실수형 데이터 형식
 
정수형에서는 0이면 0이지만 실수형은 근사값
Float    : 32비트 부동 소수점 숫자
Double   : 64비트 부동 소수점 숫자
Decimal  : 128비트 부동 소수점 숫자 - 보통 은행에서 사용
 */