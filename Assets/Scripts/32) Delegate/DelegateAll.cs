using Delegate;
using UnityEngine;

namespace delega
{
    public class DelegateAll : MonoBehaviour
    {
        //[1]대리자 선언(생성) - 변환값이 없고, 매개변수 없다
        delegate void GoHome();
        //[2] 대리자 변수 선언
        GoHome go;

        //인사하는 대리자 선언(생성)
        

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //직진 -> 우회전 -> 직진 -> 좌회전

            //직접운전
            CarDriver.GetForward();
            CarDriver.GoRight();
            CarDriver.GetForward();
            CarDriver.GoLeft();

            Debug.Log("==================");

            //[3] 대리자 변수에 메서드 등록
            go = new GoHome(CarDriver.GetForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GetForward);
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GetForward);     //메서드 등록
            go -= new GoHome(CarDriver.GetForward);     //메서드 취소

            // [4] 대리자 실행(호출)
            go.Invoke();

            Debug.Log("==================");

            //대리자 변수 선언 및 메서드 등록
            /*Say say = new Say(Hello);
            say += new Say(Hi);
            say.Invoke();*/



        }

        void Hi()
        {
            Debug.Log("Hi");
        }

        void Hello()
        {
            Debug.Log("Hello");
        }
    }
}