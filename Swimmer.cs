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
            attackShape = GameManager.globals.SWIMMER_ATTACK_SHAPE;
            AI = GameManager.globals.SWIMMER_AI;
            this.Type = type;
            name = type.ToString();
            waterWalking = true;
        }
    }
}