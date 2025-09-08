using UnityEngine;

// else 중첩문
// char c 문자 입력받아
// y 입력 받으면 YES 출력
// n 입력 받으면 NO 출력
// 그 외의 문자가 들어오면 CANCEL 출력
public class ElseNested : MonoBehaviour
{

    public char c = 'a';
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (c == 'y'|| c=='Y') Debug.Log("YES");
        else if (c == 'n'|| c=='N') Debug.Log("NO");
        else Debug.Log("CANCEL");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
