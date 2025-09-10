using Unity.VisualScripting;
using UnityEngine;

public class ArraySum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 배열 요소들의 모든 값의 총합을 구하는 프로그램
        float[] arr = { 10.5f, 20.1f, 30.3f };

        // 합을 저장하는 변수 선언
        float sum = 0;

        Debug.Log($"배열의 길이 : {arr.Length}이다");

        // [1] for문 이용
        /*for (int i = 0; i < arr.Length; i++)    // 배열의 개수가 틀릴수도 있으니 arr.Length 사용
        {
            sum = sum + arr[i];
         }
        Debug.Log($"총합은 {sum}이다");*/

        //[2] foreach문 이용
        foreach ( var item in arr )
        {
              sum += item;
        }
        Debug.Log($"총합은 {sum}이다");
    }
}
