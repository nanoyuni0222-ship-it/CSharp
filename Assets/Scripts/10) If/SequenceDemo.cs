using UnityEngine;

public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 100;
        int eng = 90;

        int total = 0;    // 총점을 저장하는 변수 생성
        double avg = 0.0; // 평균점수

        total = kor + eng; // 총점 구하기
        avg = total/2;     // 평균 구하기

        Debug.Log($"총점: {total}");
        Debug.Log($"평균: {avg:F1}");  //F1 => 소수점 첫째자리까지 출력하도록 설정, 실수 출력시에는 포맷을 정해주는 것이 좋음
    }
}

/*
 - 제어문 : 프로그램의 흐름(순서)를 정하는 명령문
  1) 순차문 : 기본적으로 모든 명령문은 순서대로 (위에서 아래로) 실행 된다
  2) 조건문 : if, switch
  3) 반복문
  4) 기타 
 */