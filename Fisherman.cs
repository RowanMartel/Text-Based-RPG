﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Fisherman : NPC
    {
        public Fisherman(int x, int y, Map map, AttackMap attackMap, Render render, NPCTypeClass.NPCType type) : base(x, y, map, attackMap, render)
        {
            health = 1;
            maxHealth = 1;
            dialogueCycle = 0;
            character = GameManager.globals.FISHERMAN_CHAR;
            this.Type = type;
            name = GameManager.globals.FISHERMAN_NAME;
        }
        public override void Interact()
        {
            switch (dialogueCycle)
            {
                case 0:
                    GameManager.playerUI.AddEvent(GameManager.globals.FISHERMAN1 + name);
                    break;
                case 1:
                    GameManager.playerUI.AddEvent(GameManager.globals.FISHERMAN2 + name);
                    break;
                case 2:
                    GameManager.playerUI.AddEvent(GameManager.globals.FISHERMAN3 + name); dialogueCycle = 0;
                    return;
            }
            dialogueCycle++;
        }
    }
}