using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Charger : Enemy
    {
        public Charger(int x, int y, Map map, AttackMap attackMap, Render render, EnemyTypeClass.EnemyType type) : base(x, y, map, attackMap, render)
        {
            health = Globals.CHARGER_HP;
            maxHealth = Globals.CHARGER_HP;
            moveAt = Globals.CHARGER_MOVEAT;
            character = Globals.CHARGER_CHAR;
            strength = Globals.CHARGER_STRENGTH;
            attackShape = Globals.SPACE_ATTACK;
            this.Type = type;
            name = type.ToString();
            kamikaze = true;
        }

        protected override void MoveAI()
        {
            // attack the player
            int[] playerPos = GameManager.GetPlayerPos();
            if (x == playerPos[0] && y == playerPos[1])
            {
                Attack(attackShape);
                return;
            }

            // or move
            if (playerPos[0] > x)
            {
                xDelta++;
                if (Move())
                {
                    if (playerPos[1] > x)
                        yDelta++;
                    else if (playerPos[1] < y)
                        yDelta--;
                }
            }
            else if (playerPos[0] < x)
            {
                xDelta--;
                if (Move())
                {
                    if (playerPos[1] > x)
                        yDelta++;
                    else if (playerPos[1] < y)
                        yDelta--;
                }
            }
            else if (playerPos[1] > y)
                yDelta++;
            else if (playerPos[1] < y)
                yDelta--;

            Move();
        }
    }
}