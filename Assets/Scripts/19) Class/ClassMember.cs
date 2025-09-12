using UnityEngine;

public class ClassMember
{
    //[1] 정적(static) 메서드
    public static void StaticMethod()           //다른 클래스에서 사용하게 하기 위한 public, 정적이므로 static, 함수선언 void
    {
        Debug.Log("[1] 정적(static) 메서드");
    }

    //[2] 인스턴스(Instance) 메서드
    public void InstanceMethod() 
    {
        Debug.Log("[2] 인스턴스(Instance) 메서드");
    }
    
}
