using UnityEngine;

namespace Method
{
    // [1] 값 전달 방법(int num), 구조체
    public class MethodIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*//정수형 변수 num 선언하고 초기화
            int num = 10;
            Debug.Log($"[1] : {num}");

            PrintNumber(num);

            Debug.Log($"[3] : {num}");*/



        }

        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2] : {num}");
        }
    }
}