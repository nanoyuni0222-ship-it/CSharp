using UnityEngine;

namespace Delegate
{
    public class CarDriver
    {
        public static void GetForward()
        {
            Debug.Log("직진");
        }

        public static void GoLeft()
        {
            Debug.Log("좌회전");
        }

        public static void GoRight()
        {
            Debug.Log("우회전");
        }
    }

    public class  Insa
    {
        public void Bye() => Debug.Log("잘가");
    }

}