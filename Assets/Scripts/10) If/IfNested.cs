using UnityEngine;

public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*// 중첩 if                         중첩 if문은 4개 이상은 하지 않는 것이 좋음, 코드에 가독성이 너무 떨어짐
        string name = "홍길동";
        int age = 20;

        //만약 이름이 홍길동과 같으면 실행 명령문 실행
        if (name == "홍길동") 
        {
            //실행문 : 만약 나이가 20과 같으면 실행문 실행
            if (age == 20)
            {
                //실행문
                Debug.Log($"이름은 {name}, 나이는 {age}");
            }
        }*/

        //if And
        int number = 1234;

        //조건 : number가 1234와 같나?, number가 1000이상인가?
        //두가지 조건을 모두 만족하면 "맞습니다 출력

        if (number == 1234 && number >= 1000) Debug.Log("맞습니다"); 
        if (number == 1234) if (number >= 1000) Debug.Log("맞습니다");

        //조건 : number가 1234와 같냐?, number가 1000이하인가?
        //두가지 조건 중 하나라도 만족하면 "하나라도 참이면 참"을 출력
        if (number == 1234 || number <= 1000) Debug.Log("하나라도 참이면 참");
        }
}
