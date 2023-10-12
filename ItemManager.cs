using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_RPG
{
    internal class ItemManager
    {
        List<Item> Items = new List<Item>();

        Render render;
        AttackMap attackMap;
        Map map;
        Player player;

        public ItemManager(Render render, AttackMap attackMap, Map map, Player player)
        {
            this.render = render;
            this.attackMap = attackMap;
            this.map = map;
            this.player = player;
        }

        public void AddItem(ItemTypeClass.ItemType type, int x, int y, int cost)
        {
            Items.Add(ItemTypeClass.CreateItem(type, x, y, render, attackMap, map, player, cost));
        }

        public void Update()
        {
            foreach (Item item in Items)
                item.Update();
        }

        public void Draw()
        {
            foreach (Item item in Items)
                item.Draw();
        }

        public void ShowHidden()
        {
            foreach (Item item in Items)
                item.Unhide();
        }

        public void InitItems()
        {
            string[] mapString = File.ReadAllLines("Items.txt");
            char[,] itemMap = new char[mapString.GetLength(0), mapString[0].Length];

            for (int i = 0; i < mapString.GetLength(0); i++)
                for (int j = 0; j < mapString[0].Length; j++)
                    itemMap[i, j] = mapString[i][j];

            for (int i = 0; i < itemMap.GetLength(0); i++)
                for (int j = 0; j < itemMap.GetLength(1); j++)
                {
                    switch (itemMap[i, j])
                    {
                        case Globals.GEM_CHAR:
                            AddItem(ItemTypeClass.ItemType.Gem, j, i, Globals.GEM_COST);
                            break;
                        case Globals.BOAT_CHAR:
                            AddItem(ItemTypeClass.ItemType.Boat, j, i, Globals.BOAT_COST);
                            break;
                        case Globals.HULA_CHAR:
                            AddItem(ItemTypeClass.ItemType.HulaHoop, j, i, Globals.HULA_COST);
                            break;
                        case Globals.SPEAR_CHAR:
                            AddItem(ItemTypeClass.ItemType.Spear, j, i, Globals.SPEAR_COST);
                            break;
                        case Globals.BOMB_CHAR:
                            AddItem(ItemTypeClass.ItemType.Bomb, j, i, Globals.BOMB_COST);
                            break;
                        case Globals.HEALTH_CHAR:
                            AddItem(ItemTypeClass.ItemType.HealthPickup, j, i, Globals.HEALTH_COST);
                            break;
                        case Globals.HEALTH_CHAR2:
                            AddItem(ItemTypeClass.ItemType.HealthPickupLarge, j, i, Globals.HEALTH_COST2);
                            break;
                        case Globals.COINBAG_CHAR:
                            AddItem(ItemTypeClass.ItemType.CoinBag, j, i, Globals.COINBAG_COST);
                            break;
                    }
                }
        }
    }
}