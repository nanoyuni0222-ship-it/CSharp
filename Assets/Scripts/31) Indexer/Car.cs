using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;

namespace Indexer
{
    public class Car
    {
        //배열 형식의 필드
        private string[] names;

        //속성 - names 배열의 길이 ; 읽기전용
        public int Length
        {
            get { return names.Length; }
        }

        //생성자 - 매개변수로 배열의 크기를 지정해준다
        public Car(int length)
        {
            //배열의 요소수 생성
            names = new string[length];
        }

        //인덱서 - names 배열 필드의 값을 읽고 쓰는 인덱서
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
        //
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}