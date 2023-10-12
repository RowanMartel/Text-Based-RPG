using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class ItemTypeClass
    {
        public enum ItemType
        {
            HealthPickup,
            Spear,
            Bomb,
            Boat,
            HealthPickupLarge,
            HulaHoop,
            Gem,
            CoinBag
        }

        public static Item CreateItem(ItemType itemType, int x, int y, Render render, AttackMap attackMap, Map map, Player player, int cost)
        {
            switch (itemType)
            {
                case ItemType.HealthPickup:
                    return new Item(Globals.HEALTH_CHAR, ConsoleColor.Magenta, x, y, itemType, render, attackMap, map, player, "health pickup", cost);
                case ItemType.HealthPickupLarge:
                    return new Item(Globals.HEALTH_CHAR2, ConsoleColor.Red, x, y, itemType, render, attackMap, map, player, "large health pickup", cost);
                case ItemType.Spear:
                    return new Item(Globals.SPEAR_CHAR, ConsoleColor.Gray, x, y, itemType, render, attackMap, map, player, "spear", cost);
                case ItemType.Bomb:
                    return new Item(Globals.BOMB_CHAR, ConsoleColor.White, x, y, itemType, render, attackMap, map, player, "bomb", cost);
                case ItemType.Boat:
                    return new Item(Globals.BOAT_CHAR, ConsoleColor.DarkYellow, x, y, itemType, render, attackMap, map, player, "boat", cost);
                case ItemType.HulaHoop:
                    return new Item(Globals.HULA_CHAR, ConsoleColor.Gray, x, y, itemType, render, attackMap, map, player, "hula-hoop", cost);
                case ItemType.Gem:
                    return new Item(Globals.GEM_CHAR, ConsoleColor.Yellow, x, y, itemType, render, attackMap, map, player, "magical gem", cost);
                case ItemType.CoinBag:
                    return new Item(Globals.COINBAG_CHAR, ConsoleColor.Yellow, x, y, itemType, render, attackMap, map, player, "bag of coins", cost);
                default:
                    return new Item(Globals.HEALTH_CHAR, ConsoleColor.Magenta, x, y, itemType, render, attackMap, map, player, "health pickup", cost);
            }
        }
    }
}