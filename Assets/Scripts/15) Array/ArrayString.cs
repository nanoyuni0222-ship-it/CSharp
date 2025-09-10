using UnityEngine;

// string : 문자(배)열
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 변수 선언 및 초기화
        string arr = "C#8";

        /*Debug.Log(arr);
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);*/

        //char
        foreach (var c in arr)   // string => 문자의 배열, string의 데이터 타입은 char ; var를 이용해서 타입 결정을 하는 것도 좋은 방법
        {
            Debug.Log(c);
        }
    }
}
