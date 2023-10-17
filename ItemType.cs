﻿using System;
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
                    return new Item(GameManager.globals.HEALTH_CHAR, GameManager.globals.HEALTH_COLOUR, x, y, itemType, render, attackMap, map, player, "health pickup", cost);
                case ItemType.HealthPickupLarge:
                    return new Item(GameManager.globals.HEALTH_CHAR2, GameManager.globals.HEALTH2_COLOUR, x, y, itemType, render, attackMap, map, player, "large health pickup", cost);
                case ItemType.Spear:
                    return new Item(GameManager.globals.SPEAR_CHAR, GameManager.globals.SPEAR_COLOUR, x, y, itemType, render, attackMap, map, player, "spear", cost);
                case ItemType.Bomb:
                    return new Item(GameManager.globals.BOMB_CHAR, GameManager.globals.BOMB_COLOUR, x, y, itemType, render, attackMap, map, player, "bomb", cost);
                case ItemType.Boat:
                    return new Item(GameManager.globals.BOAT_CHAR, GameManager.globals.BOAT_COLOUR, x, y, itemType, render, attackMap, map, player, "boat", cost);
                case ItemType.HulaHoop:
                    return new Item(GameManager.globals.HULA_CHAR, GameManager.globals.HULA_COLOUR, x, y, itemType, render, attackMap, map, player, "hula-hoop", cost);
                case ItemType.Gem:
                    return new Item(GameManager.globals.GEM_CHAR, GameManager.globals.GEM_COLOUR, x, y, itemType, render, attackMap, map, player, "magical gem", cost);
                case ItemType.CoinBag:
                    return new Item(GameManager.globals.COINBAG_CHAR, GameManager.globals.COINBAG_COLOUR, x, y, itemType, render, attackMap, map, player, "bag of coins", cost);
                default:
                    return new Item(GameManager.globals.HEALTH_CHAR, GameManager.globals.HEALTH_COLOUR, x, y, itemType, render, attackMap, map, player, "health pickup", cost);
            }
        }
    }
}