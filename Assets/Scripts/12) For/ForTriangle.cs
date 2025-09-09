using UnityEngine;

public class ForTriangle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*for (int i = 1; i <= 5; i++) 
        {
            for (int j = 1; j <= 5; j++)
            {
                Debug.Log($"i : {i}, j : {j}");
            }
            
        }*/
        /*for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Debug.Log(j);
            }
            Debug.Log("==================");*/

            //별 삼각형 만들기
        for (int i = 1; i <= 5; i++)
            {
                string stars = "";
                for (int j = 1; j <= i; j++)
                {
                    stars += "*";
                }
                Debug.Log(stars);
            }


        }

    }

/*
이중 for문,  for문은 변수 지정할 때 i부터 한글지씩 지정(이중for문 => i, j ; 삼중for문 => i, j, k ... )
for(int i = 0; i < n ; i++)
{
        for(int j = 0 ; j < m ; j++)
        {
                //반복실행문
        }
}
 */
