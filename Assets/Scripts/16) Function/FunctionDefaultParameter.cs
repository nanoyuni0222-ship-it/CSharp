using UnityEngine;

// 기본 매개변수(Default Parameter) : 매개변수 선언시 초기화 한다
public class FunctionDefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //메세지 출력함수 호출
        PrintMessage();

        string errorLog = PrintLog();
        Debug.Log(errorLog);

        //Default Parameter
        PrintError("에러메세지",4);
        PrintError("에러메세지");           // 함수 만들때 int lever에 기본값 설정했으므로 에러없이 출력됨


    }

    //메세지를 출력하는 함수
    void PrintMessage()
    {
        string msg = "디버그";
        Debug.Log(msg);
    }

    void PrintError(string message, int level = 1)
    {
        Debug.Log($"{message} : 레벨 {level}");
    }

    string PrintLog()
    {
        string log = "로그";
        return log;
    }

}
