using UnityEngine;

namespace Property
{
    public class ObjectInitializer : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Student 클래스의 인스턴스 생성
            Student s1 = new Student();
            s1.Name = "홍길동";
            s1.Age = 16;
            Debug.Log($"이름 : {s1.Name}, 나이 : {s1.Age}, 번호 : {s1.Number}");

            //개체 이니셜라이저를 사용하여 개체 초기화
            Student s2 = new Student() { Name = "백두산", Age = 16, Number = 2 };
            Debug.Log($"이름 : {s2.Name}, 나이 : {s2.Age}, 번호 : {s2.Number}");


            Student s3 = new Student() { Name = "장길산", Age = 16, Number = 3 };
            s3.SetAddress("서울시");
            Debug.Log($"이름 : {s3.Name}, 나이 : {s3.Age}, 번호 : {s3.Number}");


        }
    }
}