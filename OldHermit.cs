using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class OldHermit : NPC
    {
        public OldHermit(int x, int y, Map map, AttackMap attackMap, Render render, NPCTypeClass.NPCType type) : base(x, y, map, attackMap, render)
        {
            health = 1;
            maxHealth = 1;
            dialogueCycle = 0;
            character = GameManager.globals.HERMIT_CHAR;
            this.Type = type;
            name = GameManager.globals.HERMIT_NAME;
        }
        public override void Interact()
        {
            switch (dialogueCycle)
            {
                case 0:
                    GameManager.playerUI.AddEvent(GameManager.globals.OLDHERMIT1 + name);
                    break;
                case 1:
                    GameManager.playerUI.AddEvent(GameManager.globals.OLDHERMIT2 + name);
                    break;
                case 2:
                    GameManager.playerUI.AddEvent(GameManager.globals.OLDHERMIT3 + name); dialogueCycle = 0;
                    return;
            }
            dialogueCycle++;
        }
    }
}