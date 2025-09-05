using UnityEngine;

//숫자 이외의 데이터 형식 : bool, char, string
// char(문자형) 데이터 형식
public class CharacterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]char형 변수 선언 및 초기화
        char grade = 'A'; //한 글자만 다룰 수 있음, 문자는 작은 따옴표만 사용 사능, 한글도 쓸 수 있음
        char kor = '한';

        //[2] 사용하기
        Debug.Log("grade:"+grade); 
        Debug.Log("kor:"+kor);
    }
}
