using Unity.VisualScripting;
using UnityEngine;

public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // [1] long 형식을 변수 선언하고 가장 큰 수를 저장
       long l = long.MaxValue;
        Debug.Log($"l의 값 : {l}");

        // [2] int 형식의 변수에 i 값을 저장, 형변환
        int i = (int)l; //인트가 담을 수 있는 가장 큰 수는 21억 4천만 정도인데 long 밸류가 더 커서 오류 발생(오버플로우)
        Debug.Log($"i의 값:{i}");  // 형 변환시 데이터 값이 의미 없는 값이지만 자주 쓰임

        int x = 255;
        byte y = (byte)x;  // int는 -21억~21억까지 저장하지만 byte의 0~255, 따라서 typeconversion 해야함
        Debug.Log(x+"->"+y);
    }
}
