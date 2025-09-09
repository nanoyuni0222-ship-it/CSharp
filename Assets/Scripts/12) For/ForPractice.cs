using UnityEngine;

public class ForPractice : MonoBehaviour
{
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            /*if (i % 3 == 0 || i % 4 == 0) sum = sum + i;*/
            if (i % 3 == 0) sum = sum + i;
            else if (i % 4 == 0) sum = sum + i;         // 12의 배수를 따로 빼주지 않아도 됨
        }
        Debug.Log($"{sum}");
    }
}


/*
[Q]
1부터 100까지의 정수 중에서 3의 배수 또는 4의 배수들의 합을 구하는 프로그램 구현
 */