﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal abstract class GameCharacter
    {
        protected Map map;
        protected AttackMap attackMap;

        protected char character;
        protected ConsoleColor color;
        protected ConsoleColor attackColor;
        protected ConsoleColor baseColor;

        protected int x;
        protected int y;

        protected bool dead;

        public GameCharacter()
        {
            dead = false;
        }

        public void GetMap(Map map)
        {
            this.map = map;
        }
        public void GetAttackMap(AttackMap attackMap)
        {
            this.attackMap = attackMap;
        }

        public void Draw(Render render)
        {
            render.ChangeSpace(character, ConsoleColor.Black, color, x, y);

            color = baseColor; // returns color to normal after attacking
        }

        public virtual void Update()
        {
            if (!dead)
                dead = attackMap.IsAttack(x, y);
        }

        protected void MoveUp()
        {
            if (!map.IsWall(x, y - 1))
                y -= 1;
        }
        protected void MoveDown()
        {
            if (!map.IsWall(x, y + 1))
                y += 1;
        }
        protected void MoveLeft()
        {
            if (!map.IsWall(x - 1, y))
                x -= 1;
        }
        protected void MoveRight()
        {
            if (!map.IsWall(x + 1, y))
                x += 1;
        }

        protected void Attack()
        {
            color = attackColor;
            attackMap.AddAttack(x, y);
        }
    }
}