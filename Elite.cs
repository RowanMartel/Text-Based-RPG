using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Elite : Enemy
    {
        public Elite(int x, int y, Map map, AttackMap attackMap, Render render, EnemyTypeClass.EnemyType type) : base(x, y, map, attackMap, render)
        {
            health = GameManager.globals.ELITE_HP;
            maxHealth = GameManager.globals.ELITE_HP;
            moveAt = GameManager.globals.ELITE_MOVEAT;
            character = GameManager.globals.ELITE_CHAR;
            strength = GameManager.globals.ELITE_STRENGTH;
            attackShape = GameManager.globals.ELITE_ATTACK_SHAPE;
            AI = GameManager.globals.ELITE_AI;
            this.Type = type;
            name = GameManager.globals.ELITE_NAME;
        }
    }
}
