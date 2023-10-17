using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Roamer : Enemy
    {
        public Roamer(int x, int y, Map map, AttackMap attackMap, Render render, EnemyTypeClass.EnemyType type) : base(x, y, map, attackMap, render)
        {
            health = GameManager.globals.ROAMER_HP;
            maxHealth = GameManager.globals.ROAMER_HP;
            moveAt = GameManager.globals.ROAMER_MOVEAT;
            character = GameManager.globals.ROAMER_CHAR;
            strength = GameManager.globals.ROAMER_STRENGTH;
            attackShape = GameManager.globals.ROAMER_ATTACK_SHAPE;
            AI = GameManager.globals.ROAMER_AI;
            this.Type = type;
            name = GameManager.globals.ROAMER_NAME;
        }
    }
}