using System;
using MyGame.Characters;
using MyGame.Items;

Player player = new Player();
player.Name = "용사";

Enemy enemy = new Enemy();
enemy.Type = "고블린";

Weapon weapon = new Weapon();
weapon.Name = "불꽃검";

Potion potion = new Potion();
potion.Name = "체력 포션";

player.Attack();
enemy.TakeDamage();
weapon.GetDamage();
potion.Use();