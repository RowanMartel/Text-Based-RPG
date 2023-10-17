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
            health = GameManager.globals.CHARGER_HP;
            maxHealth = GameManager.globals.CHARGER_HP;
            moveAt = GameManager.globals.CHARGER_MOVEAT;
            character = GameManager.globals.CHARGER_CHAR;
            strength = GameManager.globals.CHARGER_STRENGTH;
            attackShape = GameManager.globals.CHARGER_ATTACK_SHAPE;
            AI = GameManager.globals.CHARGER_AI;
            this.Type = type;
            name = GameManager.globals.CHARGER_NAME;
            kamikaze = true;
        }
    }
}