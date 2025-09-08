using UnityEngine;

// 만약 스코어가 60 이상이면 "합격"이라고 출력
// 아니면 "불합격"이라고 출력
public class ElseNote : MonoBehaviour
{
    //정수형변수 score 선언하고 0으로 초기화, 입력하는 값은 스타트 위에 선언해야함
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 score가 60 이상이면 " 합격"이라고 출력
        if (score >= 60) Debug.Log("합격");
        else Debug.Log("불합격");
        Debug.Log("종료");
        
    }
}
