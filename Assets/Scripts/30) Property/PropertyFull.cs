using UnityEngine;

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //person 클래스의 인스턴스 생성
            Person person = new Person();

            //private 필드 접근(에러 - 보호수준때문)
            //person.name = "홍길동";

            //속성을 이용하여 private 필드 쓰기읽기
            person.Name = "홍길동";
            Debug.Log(person.Name);

            //메서드를 이용하여 private 필드 쓰기읽기
            person.SetName("백두산");
            Debug.Log(person.GetName());

        }
    }
}