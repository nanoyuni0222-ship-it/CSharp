using UnityEngine;

// string(문자열) 데이터 형식
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1] string 변수 선언 및 초기화
        string name = "홍길동";   //큰따옴표는 문자열
        string muliLine = @"안녕하세요                
              반갑습니다 
";                 //@는 멀티라인을 추가할 수 있게 함, 유니티 콘솔창에 logEntry로 몇 줄 볼지 설정 가능

        //[2] 사용하기
        Debug.Log("안녕하세요? 저는 " + name + "입니다.");
        Debug.Log(muliLine);
        */

        // 문자열 보간법(string Interpolation)
        string message = "문자열 보간법";
        string msg = string.Format("{0}님, {1}","홍길동", "안녕하세요");

        Debug.Log("Message:"+message); //문자열 더하기 연산
        Debug.Log($"message: {message}");   //문자열 보간법, $표시는 문자열 연산을 보간법으로 하겠다는 뜻
        Debug.Log(msg);
    
    }

}
