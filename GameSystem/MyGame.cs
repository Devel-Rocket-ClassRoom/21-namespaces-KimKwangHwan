using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Characters
{
    class Player
    {
        public string Name { get; set; }
        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }

    class Enemy
    {
        public string Type { get; set; }
        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}

namespace MyGame.Items
{
    class Weapon
    {
        public string Name { get; set; }
        public void GetDamage()
        {
            Console.WriteLine($"무기 {Name}의 공격력: 50");
        }
    }

    class Potion
    {
        public string Name { get; set; }
        public void Use()
        {
            Console.WriteLine($"포션 {Name}을(를) 사용했습니다.");
        }
    }
}