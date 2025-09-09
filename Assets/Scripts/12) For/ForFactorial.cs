using UnityEngine;

public class ForFactorial : MonoBehaviour
{
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //n!의 값을 구하라
        int factorial = 1;

        for (int i = 1; i <= n; i++) 
        { 
            factorial = factorial * i;
        }

        Debug.Log($"{n}! 값은 {factorial}입니다");
        
    }

}
