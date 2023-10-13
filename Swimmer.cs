using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Swimmer : Enemy
    {
        public Swimmer(int x, int y, Map map, AttackMap attackMap, Render render, EnemyTypeClass.EnemyType type) : base(x, y, map, attackMap, render)
        {
            health = GameManager.globals.SWIMMER_HP;
            maxHealth = GameManager.globals.SWIMMER_HP;
            moveAt = GameManager.globals.SWIMMER_MOVEAT;
            character = GameManager.globals.SWIMMER_CHAR;
            strength = GameManager.globals.SWIMMER_STRENGTH;
            attackShape = GameManager.globals.CROSS_ATTACK;
            this.Type = type;
            name = type.ToString();
            waterWalking = true;
        }

        protected override void MoveAI()
        {
            // attack the player
            int[] playerPos = GameManager.GetPlayerPos();
            if (((Math.Abs(playerPos[0] - x) == 0) && (Math.Abs(playerPos[1] - y) == 1)) || ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 0)))
            {
                Attack(attackShape);
                return;
            }

            // or move
            switch (Globals.random.Next(4))
            {
                case 0:
                    yDelta--;
                    break;
                case 1:
                    xDelta--;
                    break;
                case 2:
                    yDelta++;
                    break;
                case 3:
                    xDelta++;
                    break;
            }
            Move();
        }
    }
}