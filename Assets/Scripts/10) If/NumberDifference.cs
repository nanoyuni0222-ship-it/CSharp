using UnityEngine;

public class NumberDifference : MonoBehaviour
{

    public int first = 0;
    public int second = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*if (first > second)
        {
            int diff = first - second;
            Debug.Log($"{first}와 {second}의 차이는 {diff}이다");
        }
        else if (second == first) Debug.Log($"{first}와 {second}의 차이는 0이다");
        else 
        {
            int diff = second - first;
            Debug.Log($"{first}와 {second}의 차이는 {diff}이다");
        }*/

        // 두 수의 차이를 저장하는 변수 
        int diff = 0;

        // 두 수의 차이를 구하는 식
        if (first >= second) 
            diff = first - second;      //first>=second
        else diff = second - first;      //second>first

        //
        Debug.Log($"{first}와 {second}의 차이는 {diff}이다");

    }
}


/*
Q. 두개의 정수를 입력받아 두 정수의 차이를 양의 정수로 구하세요
first, second

[output]
{first}과 {second}의 차이는 {diff}이다.
 
 */