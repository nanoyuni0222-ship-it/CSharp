using UnityEngine;

// 2개의 수를 입력 받아 그 중 큰 수를 출력한다
public class GreaterThanEqual : MonoBehaviour
{
    public int first = 0;
    public int second = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (first > second)Debug.Log($"큰 값은 : {first}");
        else if (first < second) Debug.Log($"큰 값은 : {second}");
        else Debug.Log("두 값이 같다");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
