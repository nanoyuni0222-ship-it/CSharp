using UnityEngine;

// RelationalOperator(관계연산자, 비교연산자)
// < (작음), <= (작거나 같음), > (큼), >= (크거나 같음), == (같음), != (다름)
// 결과 : true(참), false(거짓)  => 결과 변수는 bool형이 저장
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);       
        Debug.Log(x <= y);
        Debug.Log(x > y);
        Debug.Log(x >= y);
        Debug.Log(x == y);
        Debug.Log(x != y);

        Debug.Log("AAA" == "aaa");
    }
}
