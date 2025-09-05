using UnityEngine;

// 전위 증강 연산자 => 앞에 위치한 연산자, 같은 라인에서 연산하는 우선 순위가 가장 높다(가장 먼저 연산)
// 후위 증강 연산자 : 같은 라인에서 연산하는 우선 순위가 가장 낮다, 가장 늦게 연산
public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = ++i;

        Debug.Log($"j:{j}");

        int x = 3;
        int y = x++;
        Debug.Log($"x:{x}");  // x = 4  마지막으로 x에 ++ 연산을 함으로 x=4가 나온다
        Debug.Log($"y:{y}");  // y = 3
    }
}