using UnityEngine;

namespace Indexer
{

    public class IndexDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car 클래스의 인스턴스 생성
            Car car = new Car(3);
            car[0] = "제네시스";
            car[1] = "그랜저";
            car[2] = "아반테";

            //인덱서 출력
            /*for (int i = 0; i < car.Length; i++)
            {
                Debug.Log(car[i]);
            }*/

            //반복기 구현 이후 foreach문 사용 - 인덱서 출력
            foreach (var c in car)
            {
                Debug.Log(c);

            }
        }
    }
}