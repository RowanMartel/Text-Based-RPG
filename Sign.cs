﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Sign : NPC
    {
        public Sign(int x, int y, Map map, AttackMap attackMap, Render render, NPCTypeClass.NPCType type) : base(x, y, map, attackMap, render)
        {
            health = 1;
            maxHealth = 1;
            character = GameManager.globals.SIGN_CHAR;
            this.Type = type;
            name = GameManager.globals.SIGN_NAME;
        }

        public override void Interact()
        {
            GameManager.playerUI.AddEvent(GameManager.globals.SIGN1 + name);
        }
    }
}