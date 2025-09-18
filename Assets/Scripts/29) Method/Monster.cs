using UnityEngine;

namespace Method
{
    //몬스터를 관리하는 클래스
    public class Monster
    {
        //필드
        //정적멤버변수: 단 하나만 존재해야해서 static, 공유
        //생성된 몬스터의 갯수
        public static int monsterCount =0;

        public int hp;      //체력  데이터를 저장하는 변수
        public int atk;     //공격력 데이터를 저장하는 변수

        //생성자
        public Monster(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }

        // 데미지를 입는 함수
        public void TakeDamage(int damage)
        {
            hp -= damage;
        }

    }
}