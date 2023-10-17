using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Mayor : NPC
    {
        public Mayor(int x, int y, Map map, AttackMap attackMap, Render render, NPCTypeClass.NPCType type) : base(x, y, map, attackMap, render)
        {
            health = 1;
            maxHealth = 1;
            dialogueCycle = 0;
            character = GameManager.globals.MAYOR_CHAR;
            this.Type = type;
            name = GameManager.globals.MAYOR_NAME;
        }
        public override void Interact()
        {
            switch (dialogueCycle)
            {
                case 0:
                    GameManager.playerUI.AddEvent(GameManager.globals.MAYOR1 + name);
                    break;
                case 1:
                    GameManager.playerUI.AddEvent(GameManager.globals.MAYOR2 + name);
                    break;
                case 2:
                    GameManager.playerUI.AddEvent(GameManager.globals.MAYOR3 + name);
                    break;
                case 3:
                    GameManager.playerUI.AddEvent(GameManager.globals.MAYOR4 + name); dialogueCycle = 3;
                    return;
            }
            dialogueCycle++;
        }
    }
}