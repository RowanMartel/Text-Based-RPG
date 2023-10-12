using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Lava : Enemy
    {
        public Lava(int x, int y, Map map, AttackMap attackMap, Render render, EnemyTypeClass.EnemyType type) : base(x, y, map, attackMap, render)
        {
            health = Globals.LAVA_HP;
            maxHealth = Globals.LAVA_HP;
            moveAt = Globals.LAVA_MOVEAT;
            character = Globals.LAVA_CHAR;
            strength = Globals.LAVA_STRENGTH;
            attackShape = Globals.RING_ATTACK;
            this.Type = type;
            name = type.ToString();
        }

        protected override void MoveAI()
        {
            Attack(attackShape);
        }
    }
}