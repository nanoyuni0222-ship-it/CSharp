using UnityEngine;

using Korea.Suwon;      //Korea.Suwon에 있는 클래스를 가져다가 사용
using Su = Korea.Suwon;     // Korea.Suwon을 Su 네임스페이스 별칭으로 만들어 사용

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 네임스페이스 전체를 지정해서 사용
        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();

        Korea.Suwon.Car su = new Korea.Suwon.Car();
        su.Run();

        //[2] using을 선언해서 사용
        Car seoul = new Car();
        seoul.Run();

        //[3] 네임스페이스의 별칭을 지정해서 사용
        Su.Car suwon = new Su.Car();
        suwon.Run();

        //[4] 트럭
        Korea.Seoul.Truck tr = new Korea.Seoul.Truck();
        tr.Run();

    }
}
