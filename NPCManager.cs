using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Text_Based_RPG
{
    internal class NPCManager
    {
        private Render render;
        private Map map;
        private AttackMap attackMap;
        private Player player;
        private ItemManager itemManager;
        private char[,] npcMap;

        public NPCManager(AttackMap attackMap, Player player, Render render, Map map, ItemManager itemManager)
        {
            this.attackMap = attackMap;
            this.player = player;
            this.render = render;
            this.map = map;
            this.itemManager = itemManager;

            string[] mapString = File.ReadAllLines("NPCs.txt");
            npcMap = new char[mapString.GetLength(0), mapString[0].Length];

            for (int i = 0; i < mapString.GetLength(0); i++)
                for (int j = 0; j < mapString[0].Length; j++)
                    npcMap[i, j] = mapString[i][j];
        }

        List<NPC> npcs = new List<NPC>();

        public void AddNPC(NPCTypeClass.NPCType Type, int x, int y)
        {
            npcs.Add(NPCTypeClass.CreateNPC(Type, x, y, map, attackMap, render));
        }

        public void Update()
        {
            foreach (NPC npc in npcs)
            {
                npc.Update();
            }
        }

        public void Draw()
        {
            foreach (NPC npc in npcs)
            {
                
                npc.Draw();
            }
        }

        public void NPCInteract()
        {
            foreach (NPC npc in npcs)
            {
                if (attackMap.IsAttack(npc.GetPos()[0], npc.GetPos()[1]) && attackMap.PlayerAttackCheck(npc.GetPos()[0], npc.GetPos()[1]))
                {
                    npc.Interact();
                }
            }
        }

        public void InitNPCs()
        {
            for (int i = 0; i < npcMap.GetLength(0); i++)
                for (int j = 0; j < npcMap.GetLength(1); j++)
                {
                    switch (npcMap[i, j])
                    {
                        case Globals.QUEST_CHAR:
                            AddNPC(NPCTypeClass.NPCType.QuestDealer, j, i);
                            break;
                        case Globals.SHOP_CHAR:
                            AddNPC(NPCTypeClass.NPCType.ShopKeep, j, i);
                            break;
                        case Globals.GAMBLER_CHAR:
                            AddNPC(NPCTypeClass.NPCType.Gambler, j, i);
                            break;
                        case Globals.FISHERMAN_CHAR:
                            AddNPC(NPCTypeClass.NPCType.Fisherman, j, i);
                            break;
                        case Globals.MAYOR_CHAR:
                            AddNPC(NPCTypeClass.NPCType.Mayor, j, i);
                            break;
                        case Globals.SOLDIER_CHAR:
                            AddNPC(NPCTypeClass.NPCType.RetiredSoldier, j, i);
                            break;
                        case Globals.HERMIT_CHAR:
                            AddNPC(NPCTypeClass.NPCType.OldHermit, j, i);
                            break;
                        case Globals.GRASSGUY_CHAR:
                            AddNPC(NPCTypeClass.NPCType.GrassGuy, j, i);
                            break;
                        case Globals.SANDGUY_CHAR:
                            AddNPC(NPCTypeClass.NPCType.SandGuy, j, i);
                            break;
                        case Globals.DOCKGUY_CHAR:
                            AddNPC(NPCTypeClass.NPCType.DockGuy, j, i);
                            break;
                        case Globals.SIGN_CHAR:
                            AddNPC(NPCTypeClass.NPCType.Sign, j, i);
                            break;
                        case Globals.JOURNAL_CHAR:
                            AddNPC(NPCTypeClass.NPCType.Journal, j, i);
                            break;
                    }
                }
        }

        public bool IsNPCHere(int x, int y)
        {
            switch (npcMap[y, x])
            {
                case Globals.QUEST_CHAR:
                case Globals.SHOP_CHAR:
                case Globals.GAMBLER_CHAR:
                case Globals.FISHERMAN_CHAR:
                case Globals.MAYOR_CHAR:
                case Globals.SOLDIER_CHAR:
                case Globals.HERMIT_CHAR:
                case Globals.GRASSGUY_CHAR:
                case Globals.SANDGUY_CHAR:
                case Globals.DOCKGUY_CHAR:
                case Globals.SIGN_CHAR:
                case Globals.JOURNAL_CHAR:
                    return true;
                default: 
                    return false;
            }
        }
    }
}