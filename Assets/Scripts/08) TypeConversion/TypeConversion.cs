using UnityEngine;

// 형식 변환(TypeConversion)
public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double d = 12.34;     // d를 double형 변수로 선언하고 12.34를 저장, double => 64bit
        int i = 1234;         // i를 int형 변수로 선언하고 1234를 저장,     int => 32 bit

        // [1] 묵시적(암묵적, 암시적) 형식 변환: double > int
        d = i;                // d가 i보다 그릇이 크기 때문에 오류가 발생하지 않음
        Debug.Log($"암시적 형식변환:{d}");

        d = 12.34;
        i = 1234;

        // [2] 명시적 형식 변환: int < double
        i = (int)d;
        Debug.Log($"명시적 형식 변환:{i}");

        d = 12.34;

        // 명시적, 암묵적 형식 변환은 숫자에서만 가능

        // [3] 수 이외의 형식 변환
        string s = "";        // 빈값으로 초기화
        s = d.ToString();     // 숫자를 문자로 변환
        Debug.Log($"형식변환:{s}");
    }
}
