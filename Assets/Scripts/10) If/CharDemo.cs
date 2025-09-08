using UnityEngine;

// 문자 비교식 예제
// 입력 받은 알파벳 문자의 대소문자 판별
public class CharDemo : MonoBehaviour
{
    public char c = 'a';

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 대소문자 판별
        if (c >= 'A' && c <= 'Z') Debug.Log($"{c}는 대문자입니다.");
        else if (c >= 'a' && c <= 'z') Debug.Log($"{c}는 소문자입니다.");
        else Debug.Log($"{c}는 !알파벳입니다");

    }
}
