using UnityEngine;

// [1] enum 정의, 선언
// enum의 값을 정수형, 문자열로 사용이 가능
//동물들을 구분하는 열거형
enum Animals            // 제일 위에 값은 0, 그 밑은 1, ...      ; 저장된 값 : 바로 위에 수 + 1
{
    Rabbit,
    Dragon,
    Snake
}

enum Animale
{
    Horse,      // 0
    Sheep = 5,  // 1->5
    Monkey      //6
}

public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] enum 사용 - enum 변수 선언하고 초기화
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"Animals.Dragon : {num}, {str}");

        Debug.Log((int)Animale.Monkey);

    }

}
