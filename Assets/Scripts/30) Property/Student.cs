using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

namespace Property
{
    public class Student
    {
        //필드
        private string name;
        private string address;

        //속성
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 자동 속성
        public int Age {  get; set; }

        public int Number { get; set; } = 1;

        //메서드를 이용하여 address 읽기, 쓰기
        public void SetAddress(string _address)
        {
            this.address = _address;
        }

    }
}