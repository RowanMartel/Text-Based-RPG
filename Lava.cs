﻿using System;
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
            health = GameManager.globals.LAVA_HP;
            maxHealth = GameManager.globals.LAVA_HP;
            moveAt = GameManager.globals.LAVA_MOVEAT;
            character = GameManager.globals.LAVA_CHAR;
            strength = GameManager.globals.LAVA_STRENGTH;
            attackShape = GameManager.globals.LAVA_ATTACK_SHAPE;
            AI = GameManager.globals.LAVA_AI;
            this.Type = type;
            name = GameManager.globals.LAVA_NAME;
        }
    }
}