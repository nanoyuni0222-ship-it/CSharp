using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    //변수 선언
    public int answer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (answer) 
        {
            case 1:
                Debug.Log("1번을 선택했습니다");
                break;
            case 2:
                Debug.Log("2번을 선택했습니다");
                break;
            case 3:
                Debug.Log("3번을 선택했습니다");
                break;
            case 4:
                Debug.Log("4번을 선택했습니다");
                break;   
            default:
                Debug.Log("잘못 선택했습니다");
                break;
        }       
    }
}
