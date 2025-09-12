using UnityEngine;

//우선 순위를 정의하는 열거형 생성
enum Priority
{
    High,
    Normal,
    Low
}


public class EnumerationDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] enum 사용 - 변수 선언
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        //
        Debug.Log($"{high},{normal},{low}");
    }

}

/*
열거형 (Enumeration, Enum)
: 하나의 이름으로 서로 관련 있는 정수 값을 갖는 상수들의 집합
: 사용자 정의 데이터 형식

enum (eum 이름)       // 정의 자체가 정수 값을 갖는 상수들, 따라서 데이터타입 설정x
{
    상수명, 
    상수명,
    ...
}

 */