using UnityEngine;

//전역변수(필드ㅡ 멤버변수)
//지역변수
public class FunctionScope : MonoBehaviour
{

    string Message = "전역 변수"; // 필드, 멤버 변수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Message);

        PrintMessage();

        ShowMessage(); 
    }

    //메세지를 출력하는 함수
    void ShowMessage() 
    {

        string message = "지역변수";
        Debug.Log(message);

    }

    void PrintMessage ()
    {
        Debug.Log(Message);
    }


}


