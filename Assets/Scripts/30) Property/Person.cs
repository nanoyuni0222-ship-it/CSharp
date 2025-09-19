using UnityEngine;

namespace Property
{
    public class Person
    {
        //필드
        private string name;    //이름을 저장하는 필드

        //속성(property)를 이용해서 name에 접근 사용
        public string Name 
        {   
            get { return name; }
            set { name = value; }
        }


        //private한 필드를 public한 메서드를 이용하여 쓰고 읽는다
        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
