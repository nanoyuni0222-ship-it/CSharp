using UnityEngine;

public class BreakDemo : MonoBehaviour
{
    public int n = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int sum = 0;
        int i = 0;

        for (i = 1; i < n; i++) 
        {sum = sum + i;
            if (sum >= 22) break;
            Debug.Log($"합은 {sum}입니다");*/



        int sum = 0;
        int i = 1;
                    
         while (i <= n) 
         {
            sum = sum + i;

            if (sum >= 22) break;
                        
            i++;                        

            Debug.Log($"합은 {sum}입니다");
        }

    }
}


/*
[Q] 
1부터 10까지의 정수의 합(sum)을 구하는 프로그램 구현
합(sum)이 22 이상이 되면 더이상 합을 구하지 않는다.
 */