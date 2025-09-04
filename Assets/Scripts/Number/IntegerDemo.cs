using UnityEngine;

public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = int.MinValue;  //minvalue > 저장할 수 있는 최솟값
        int max = int.MaxValue;  //maxvalue > 저장할 수 있는 최댓값

        Debug.Log("int 최소값:" + min);
        Debug.Log("int 최대값:" + max);
    }

}

/*
정수형(Integer) 데이터 형식

SignedInteger (+, -) 부호가 있는 정수형 데이터 형식, 0 포함
sbyte :  8 Bit (-128~127)
short : 16 Bit (-32768~32767)
int   : 32 Bit (-21억~21억)     정수는 보통 int, 실수는 보통 float 쓰면 거의 다 된다.
long  : 64 Bit

UnSignedInteger 부호가 없는 정수형 데이터 형식(0부터 양의 정수만 저장)
byte :    8 Bit 0~225
ushort : 16 Bit 0~65535
<<<<<<< HEAD
uint   :  32 Bit 0~42억
ulong  :  64 Bit
=======
int   :  32 Bit 0~42억
long  :  64 Bit
>>>>>>> a7f042e98461757a110b08db429869fd22c06bc6

 */