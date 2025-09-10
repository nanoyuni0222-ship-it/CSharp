using UnityEngine;

public class ContinueDemo : MonoBehaviour
{
    public int n = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 n까지 정수의 합
        int sum = 0;

        for (int i = 1; i <= n; i++) 
        {
            if (i % 3 == 0) continue;  //3의 배수를 제외
            sum = sum + i;
        }
        Debug.Log(sum);


    }
}

/*
[Q]
1부터 100까지의 정수의 합을 구하는 데 3의 배수를 제외한 나머지의 합을 구하시오.
 */
