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
            health = Constants.LAVA_HP;
            maxHealth = Constants.LAVA_HP;
            moveAt = Constants.LAVA_MOVEAT;
            character = Constants.LAVA_CHAR;
            strength = Constants.LAVA_STRENGTH;
            attackShape = Constants.RING_ATTACK;
            this.Type = type;
            name = type.ToString();
        }

        protected override void MoveAI()
        {
            Attack(attackShape);
        }
    }
}