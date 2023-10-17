using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Text_Based_RPG
{
    internal class Globals
    {
        // item value constants
        public int HEAL_SMALL { get; set; }
        public int HEAL_LARGE { get; set; }
        public int SMALL_BOMB_DAMAGE { get; set; }

        // attack shape constants
        public enum AttackShape
        {
            CrossAttack,
            SpaceAttack,
            LongAttack,
            RingAttack,
            XAttack
        }
        public AttackShape PLAYER_DEFAULT_ATTACK_SHAPE { get; set; }
        public AttackShape SPEAR_ATTACK_SHAPE { get; set; }
        public AttackShape HULA_ATTACK_SHAPE { get; set; }
        public AttackShape ROAMER_ATTACK_SHAPE { get; set; }
        public AttackShape CHARGER_ATTACK_SHAPE { get; set; }
        public AttackShape LAVA_ATTACK_SHAPE { get; set; }
        public AttackShape SWIMMER_ATTACK_SHAPE { get; set; }
        public AttackShape ELITE_ATTACK_SHAPE { get; set; }
        public string PLAYER_DEFAULT_ATTACK_SHAPE_STR { get; set; }
        public string SPEAR_ATTACK_SHAPE_STR { get; set; }
        public string HULA_ATTACK_SHAPE_STR { get; set; }
        public string ROAMER_ATTACK_SHAPE_STR { get; set; }
        public string CHARGER_ATTACK_SHAPE_STR { get; set; }
        public string LAVA_ATTACK_SHAPE_STR { get; set; }
        public string SWIMMER_ATTACK_SHAPE_STR { get; set; }
        public string ELITE_ATTACK_SHAPE_STR { get; set; }

        // enemy ai constants
        public enum EnemyAI
        {
            Random,
            Chase,
            Static
        }
        public EnemyAI ROAMER_AI { get; set; }
        public EnemyAI CHARGER_AI { get; set; }
        public EnemyAI LAVA_AI { get; set; }
        public EnemyAI SWIMMER_AI { get; set; }
        public EnemyAI ELITE_AI { get; set; }
        public string ROAMER_AI_STR { get; set; }
        public string CHARGER_AI_STR { get; set; }
        public string LAVA_AI_STR { get; set; }
        public string SWIMMER_AI_STR { get; set; }
        public string ELITE_AI_STR { get; set; }

        // character constants
        public char PLAYER_CHAR { get; set; }
        public char SHOP_CHAR { get; set; }
        public char GAMBLER_CHAR { get; set; }
        public char QUEST_CHAR { get; set; }
        public char FISHERMAN_CHAR { get; set; }
        public char MAYOR_CHAR { get; set; }
        public char SOLDIER_CHAR { get; set; }
        public char HERMIT_CHAR { get; set; }
        public char GRASSGUY_CHAR { get; set; }
        public char SANDGUY_CHAR { get; set; }
        public char DOCKGUY_CHAR { get; set; }
        public char SIGN_CHAR { get; set; }
        public char JOURNAL_CHAR { get; set; }
        public char ROAMER_CHAR { get; set; }
        public char CHARGER_CHAR { get; set; }
        public char LAVA_CHAR { get; set; }
        public char SWIMMER_CHAR { get; set; }
        public char ELITE_CHAR { get; set; }
        public char HEALTH_CHAR { get; set; }
        public char HEALTH_CHAR2 { get; set; }
        public char COINBAG_CHAR { get; set; }
        public char SPEAR_CHAR { get; set; }
        public char BOMB_CHAR { get; set; }
        public char BOAT_CHAR { get; set; }
        public char HULA_CHAR { get; set; }
        public char GEM_CHAR { get; set; }

        // character colour constants
        public ConsoleColor CHARACTER_COLOUR { get; set; }
        public ConsoleColor ENEMY_COLOUR { get; set; }
        public ConsoleColor ENEMY_ATTACKING_COLOUR { get; set; }
        public ConsoleColor PLAYER_COLOUR { get; set; }
        public ConsoleColor PLAYER_ATTACKING_COLOUR { get; set; }
        public ConsoleColor NPC_COLOUR { get; set; }
        public ConsoleColor ATTACK_COLOUR { get; set; }
        public string CHARACTER_COLOUR_STR { get; set; }
        public string ENEMY_COLOUR_STR { get; set; }
        public string ENEMY_ATTACKING_COLOUR_STR { get; set; }
        public string PLAYER_COLOUR_STR { get; set; }
        public string PLAYER_ATTACKING_COLOUR_STR { get; set; }
        public string NPC_COLOUR_STR { get; set; }
        public string ATTACK_COLOUR_STR { get; set; }

        // item colour constants
        public ConsoleColor HEALTH_COLOUR { get; set; }
        public ConsoleColor HEALTH2_COLOUR { get; set; }
        public ConsoleColor SPEAR_COLOUR { get; set; }
        public ConsoleColor BOAT_COLOUR { get; set; }
        public ConsoleColor BOMB_COLOUR { get; set; }
        public ConsoleColor HULA_COLOUR { get; set; }
        public ConsoleColor GEM_COLOUR { get; set; }
        public ConsoleColor COINBAG_COLOUR { get; set; }
        public ConsoleColor ITEM_BG_COLOUR { get; set; }
        public string HEALTH_COLOUR_STR { get; set; }
        public string HEALTH2_COLOUR_STR { get; set; }
        public string SPEAR_COLOUR_STR { get; set; }
        public string BOAT_COLOUR_STR { get; set; }
        public string BOMB_COLOUR_STR { get; set; }
        public string HULA_COLOUR_STR { get; set; }
        public string GEM_COLOUR_STR { get; set; }
        public string COINBAG_COLOUR_STR { get; set; }
        public string ITEM_BG_COLOUR_STR { get; set; }

        // map display constants
        public char MAP_GRASS { get; set; }
        public char MAP_WATER { get; set; }
        public char MAP_MOUNTAIN { get; set; }
        public char MAP_FOREST { get; set; }
        public char MAP_SAND { get; set; }
        public char MAP_WOOD { get; set; }
        public char MAP_WALL { get; set; }
        public char MAP_HOLE { get; set; }
        public char MAP_HOLE_FALSE { get; set; }
        public char MAP_SHOP { get; set; }
        public char MAP_SHOP_RESTOCKING { get; set; }

        // map colour constants
        public ConsoleColor GRASS_COLOUR_BG { get; set; }
        public ConsoleColor WATER_COLOUR_BG { get; set; }
        public ConsoleColor MOUNTAIN_COLOUR_BG { get; set; }
        public ConsoleColor FOREST_COLOUR_BG { get; set; }
        public ConsoleColor SAND_COLOUR_BG { get; set; }
        public ConsoleColor WOOD_COLOUR_BG { get; set; }
        public ConsoleColor WALL_COLOUR_BG { get; set; }
        public ConsoleColor HOLE_COLOUR_BG { get; set; }
        public ConsoleColor HOLE_FALSE_COLOUR_BG { get; set; }
        public ConsoleColor SHOP_COLOUR_BG { get; set; }
        public ConsoleColor SHOP_RESTOCKING_COLOUR_BG { get; set; }
        public ConsoleColor GRASS_COLOUR_FG { get; set; }
        public ConsoleColor WATER_COLOUR_FG { get; set; }
        public ConsoleColor MOUNTAIN_COLOUR_FG { get; set; }
        public ConsoleColor FOREST_COLOUR_FG { get; set; }
        public ConsoleColor SAND_COLOUR_FG { get; set; }
        public ConsoleColor WOOD_COLOUR_FG { get; set; }
        public ConsoleColor WALL_COLOUR_FG { get; set; }
        public ConsoleColor HOLE_COLOUR_FG { get; set; }
        public ConsoleColor HOLE_FALSE_COLOUR_FG { get; set; }
        public ConsoleColor SHOP_COLOUR_FG { get; set; }
        public ConsoleColor SHOP_RESTOCKING_COLOUR_FG { get; set; }
        public string GRASS_COLOUR_BG_STR { get; set; }
        public string WATER_COLOUR_BG_STR { get; set; }
        public string MOUNTAIN_COLOUR_BG_STR { get; set; }
        public string FOREST_COLOUR_BG_STR { get; set; }
        public string SAND_COLOUR_BG_STR { get; set; }
        public string WOOD_COLOUR_BG_STR { get; set; }
        public string WALL_COLOUR_BG_STR { get; set; }
        public string HOLE_COLOUR_BG_STR { get; set; }
        public string HOLE_FALSE_COLOUR_BG_STR { get; set; }
        public string SHOP_COLOUR_BG_STR { get; set; }
        public string SHOP_RESTOCKING_COLOUR_BG_STR { get; set; }
        public string GRASS_COLOUR_FG_STR { get; set; }
        public string WATER_COLOUR_FG_STR { get; set; }
        public string MOUNTAIN_COLOUR_FG_STR { get; set; }
        public string FOREST_COLOUR_FG_STR { get; set; }
        public string SAND_COLOUR_FG_STR { get; set; }
        public string WOOD_COLOUR_FG_STR { get; set; }
        public string WALL_COLOUR_FG_STR { get; set; }
        public string HOLE_COLOUR_FG_STR { get; set; }
        public string HOLE_FALSE_COLOUR_FG_STR { get; set; }
        public string SHOP_COLOUR_FG_STR { get; set; }
        public string SHOP_RESTOCKING_COLOUR_FG_STR { get; set; }

        // health constants
        public int PLAYER_HP { get; set; }
        public int ROAMER_HP { get; set; }
        public int CHARGER_HP { get; set; }
        public int LAVA_HP { get; set; }
        public int SWIMMER_HP { get; set; }
        public int ELITE_HP { get; set; }

        // coin constants
        public int PLAYER_START_COINS { get; set; }
        public int COINBAG_RANGE { get; set; }
        public int COINBAG_MIN { get; set; }
        public int HEALTH_COST { get; set; }
        public int HEALTH_COST2 { get; set; }
        public int SPEAR_COST { get; set; }
        public int BOMB_COST { get; set; }
        public int BOAT_COST { get; set; }
        public int HULA_COST { get; set; }
        public int GEM_COST { get; set; }
        public int COINBAG_COST { get; set; }

        // quest char constants
        public char UNACCEPTED_QUEST { get; set; }
        public char ACCEPTED_QUEST { get; set; }
        public char NOT_TURNED_IN_QUEST { get; set; }
        public char RANDOM_QUEST_CHAR { get; set; }
        public char GIVE_HEALTH_QUEST_CHAR { get; set; }
        public char GIVE_SPEAR_QUEST_CHAR { get; set; }
        public char GIVE_HULA_QUEST_CHAR { get; set; }

        // quests colour constants
        public ConsoleColor UNACCEPTED_QUEST_COLOUR { get; set; }
        public ConsoleColor ACCEPTED_QUEST_COLOUR { get; set; }
        public ConsoleColor NOT_TURNED_IN_QUEST_COLOUR { get; set; }
        public ConsoleColor QUEST_BG_COLOUR { get; set; }
        public string UNACCEPTED_QUEST_COLOUR_STR { get; set; }
        public string ACCEPTED_QUEST_COLOUR_STR { get; set; }
        public string NOT_TURNED_IN_QUEST_COLOUR_STR { get; set; }
        public string QUEST_BG_COLOUR_STR { get; set; }

        // quest reward constants
        public int GIVE_HEALTH_QUEST_REWARD_RANGE { get; set; }
        public int GIVE_HEALTH_QUEST_REWARD_MIN { get; set; }
        public int GIVE_SPEAR_QUEST_REWARD_RANGE { get; set; }
        public int GIVE_SPEAR_QUEST_REWARD_MIN { get; set; }
        public int GIVE_HULA_QUEST_REWARD_RANGE { get; set; }
        public int GIVE_HULA_QUEST_REWARD_MIN { get; set; }

        // move-at constants
        public int ROAMER_MOVEAT { get; set; }
        public int CHARGER_MOVEAT { get; set; }
        public int LAVA_MOVEAT { get; set; }
        public int SWIMMER_MOVEAT { get; set; }
        public int ELITE_MOVEAT { get; set; }

        // strength constants
        public int PLAYER_STRENGTH { get; set; }
        public int ROAMER_STRENGTH { get; set; }
        public int CHARGER_STRENGTH { get; set; }
        public int LAVA_STRENGTH { get; set; }
        public int SWIMMER_STRENGTH { get; set; }
        public int ELITE_STRENGTH { get; set; }

        // random class constant
        public static Random random = new Random();

        // player starting position
        public int START_X { get; set; }
        public int START_Y { get; set; }

        // camera radius
        public int CAMERA_RADIUS { get; set; }

        // event log length
        public int EVENT_LOG_LENGTH { get; set; }

        public void LoadAllData()
        {
            // items data
            string itemsDataPath = "jsons/Items_data.json";
            string itemsJsonData = File.ReadAllText(itemsDataPath);
            var itemsData = JsonSerializer.Deserialize<Globals>(itemsJsonData);

            // enemy data
            string enemyDataPath = "jsons/Enemy_data.json";
            string enemyJsonData = File.ReadAllText(enemyDataPath);
            var enemyData = JsonSerializer.Deserialize<Globals>(enemyJsonData);

            // npc data
            string npcDataPath = "jsons/NPC_data.json";
            string npcJsonData = File.ReadAllText(npcDataPath);
            var npcData = JsonSerializer.Deserialize<Globals>(npcJsonData);

            // quests data
            string questsDataPath = "jsons/Quests_data.json";
            string questsJsonData = File.ReadAllText(questsDataPath);
            var questsData = JsonSerializer.Deserialize<Globals>(questsJsonData);
            
            // map data
            string mapDataPath = "jsons/Map_data.json";
            string mapJsonData = File.ReadAllText(mapDataPath);
            var mapData = JsonSerializer.Deserialize<Globals>(mapJsonData);

            // player and misc data
            string playerAndMiscDataPath = "jsons/PlayerAndMisc_data.json";
            string playerAndMiscJsonData = File.ReadAllText(playerAndMiscDataPath);
            var playerAndMiscData = JsonSerializer.Deserialize<Globals>(playerAndMiscJsonData);

            CopySettings(itemsData, enemyData, npcData, questsData, mapData, playerAndMiscData);
        }

        private void CopySettings(Globals itemsData, Globals enemyData, Globals npcData, Globals questsData, Globals mapData, Globals playerAndMiscData)
        {
            // items data
            HEAL_SMALL = itemsData.HEAL_SMALL;
            HEAL_LARGE = itemsData.HEAL_LARGE;
            SMALL_BOMB_DAMAGE = itemsData.SMALL_BOMB_DAMAGE;
            HEALTH_CHAR = itemsData.HEALTH_CHAR;
            HEALTH_CHAR2 = itemsData.HEALTH_CHAR2;
            COINBAG_CHAR = itemsData.COINBAG_CHAR;
            SPEAR_CHAR = itemsData.SPEAR_CHAR;
            BOMB_CHAR = itemsData.BOMB_CHAR;
            BOAT_CHAR = itemsData.BOAT_CHAR;
            HULA_CHAR = itemsData.HULA_CHAR;
            GEM_CHAR = itemsData.GEM_CHAR;
            COINBAG_RANGE = itemsData.COINBAG_RANGE;
            COINBAG_MIN = itemsData.COINBAG_MIN;
            HEALTH_COST = itemsData.HEALTH_COST;
            HEALTH_COST2 = itemsData.HEALTH_COST2;
            SPEAR_COST = itemsData.SPEAR_COST;
            BOMB_COST = itemsData.BOMB_COST;
            BOAT_COST = itemsData.BOAT_COST;
            HULA_COST = itemsData.HULA_COST;
            GEM_COST = itemsData.GEM_COST;
            COINBAG_COST = itemsData.COINBAG_COST;
            HEALTH_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.HEALTH_COLOUR_STR);
            HEALTH2_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.HEALTH2_COLOUR_STR);
            SPEAR_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.SPEAR_COLOUR_STR);
            BOMB_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.BOMB_COLOUR_STR);
            BOAT_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.BOAT_COLOUR_STR);
            HULA_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.HULA_COLOUR_STR);
            GEM_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.GEM_COLOUR_STR);
            COINBAG_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemsData.COINBAG_COLOUR_STR);
            SPEAR_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), itemsData.SPEAR_ATTACK_SHAPE_STR);
            HULA_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), itemsData.HULA_ATTACK_SHAPE_STR);

            // enemies data
            ROAMER_CHAR = enemyData.ROAMER_CHAR;
            CHARGER_CHAR = enemyData.CHARGER_CHAR;
            LAVA_CHAR = enemyData.LAVA_CHAR;
            SWIMMER_CHAR = enemyData.SWIMMER_CHAR;
            ELITE_CHAR = enemyData.ELITE_CHAR;
            ROAMER_HP = enemyData.ROAMER_HP;
            CHARGER_HP = enemyData.CHARGER_HP;
            LAVA_HP = enemyData.LAVA_HP;
            SWIMMER_HP = enemyData.SWIMMER_HP;
            ELITE_HP = enemyData.ELITE_HP;
            ROAMER_MOVEAT = enemyData.ROAMER_MOVEAT;
            CHARGER_MOVEAT = enemyData.CHARGER_MOVEAT;
            LAVA_MOVEAT = enemyData.LAVA_MOVEAT;
            SWIMMER_MOVEAT = enemyData.SWIMMER_MOVEAT;
            ELITE_MOVEAT = enemyData.ELITE_MOVEAT;
            ROAMER_STRENGTH = enemyData.ROAMER_STRENGTH;
            CHARGER_STRENGTH = enemyData.CHARGER_STRENGTH;
            LAVA_STRENGTH = enemyData.LAVA_STRENGTH;
            SWIMMER_STRENGTH = enemyData.SWIMMER_STRENGTH;
            ELITE_STRENGTH = enemyData.ELITE_STRENGTH;
            ENEMY_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), enemyData.ENEMY_COLOUR_STR);
            ENEMY_ATTACKING_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), enemyData.ENEMY_ATTACKING_COLOUR_STR);
            ROAMER_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), enemyData.ROAMER_ATTACK_SHAPE_STR);
            CHARGER_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), enemyData.LAVA_ATTACK_SHAPE_STR);
            LAVA_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), enemyData.ROAMER_ATTACK_SHAPE_STR);
            SWIMMER_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), enemyData.SWIMMER_ATTACK_SHAPE_STR);
            ELITE_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), enemyData.ELITE_ATTACK_SHAPE_STR);
            ROAMER_AI = (EnemyAI)Enum.Parse(typeof(EnemyAI), enemyData.ROAMER_AI_STR);
            CHARGER_AI = (EnemyAI)Enum.Parse(typeof(EnemyAI), enemyData.CHARGER_AI_STR);
            LAVA_AI = (EnemyAI)Enum.Parse(typeof(EnemyAI), enemyData.LAVA_AI_STR);
            SWIMMER_AI = (EnemyAI)Enum.Parse(typeof(EnemyAI), enemyData.SWIMMER_AI_STR);
            ELITE_AI = (EnemyAI)Enum.Parse(typeof(EnemyAI), enemyData.ELITE_AI_STR);

            // npc data
            SHOP_CHAR = npcData.SHOP_CHAR;
            GAMBLER_CHAR = npcData.GAMBLER_CHAR;
            QUEST_CHAR = npcData.QUEST_CHAR;
            FISHERMAN_CHAR = npcData.FISHERMAN_CHAR;
            MAYOR_CHAR = npcData.MAYOR_CHAR;
            SOLDIER_CHAR = npcData.SOLDIER_CHAR;
            HERMIT_CHAR = npcData. HERMIT_CHAR;
            GRASSGUY_CHAR = npcData.GRASSGUY_CHAR;
            SANDGUY_CHAR = npcData.SANDGUY_CHAR;
            DOCKGUY_CHAR = npcData.DOCKGUY_CHAR;
            SIGN_CHAR = npcData.SIGN_CHAR;
            JOURNAL_CHAR = npcData.JOURNAL_CHAR;
            NPC_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), npcData.NPC_COLOUR_STR);

            // quests data
            UNACCEPTED_QUEST = questsData.UNACCEPTED_QUEST;
            ACCEPTED_QUEST = questsData.ACCEPTED_QUEST;
            NOT_TURNED_IN_QUEST = questsData.NOT_TURNED_IN_QUEST;
            RANDOM_QUEST_CHAR = questsData.RANDOM_QUEST_CHAR;
            GIVE_HEALTH_QUEST_CHAR = questsData.GIVE_HEALTH_QUEST_CHAR;
            GIVE_SPEAR_QUEST_CHAR = questsData.GIVE_SPEAR_QUEST_CHAR;
            GIVE_HULA_QUEST_CHAR = questsData.GIVE_HULA_QUEST_CHAR;
            GIVE_HEALTH_QUEST_REWARD_RANGE = questsData.GIVE_HEALTH_QUEST_REWARD_RANGE;
            GIVE_HEALTH_QUEST_REWARD_MIN = questsData.GIVE_HEALTH_QUEST_REWARD_MIN;
            GIVE_SPEAR_QUEST_REWARD_RANGE = questsData.GIVE_SPEAR_QUEST_REWARD_RANGE;
            GIVE_SPEAR_QUEST_REWARD_MIN = questsData.GIVE_SPEAR_QUEST_REWARD_MIN;
            GIVE_HULA_QUEST_REWARD_RANGE = questsData.GIVE_HULA_QUEST_REWARD_RANGE;
            GIVE_HULA_QUEST_REWARD_MIN = questsData.GIVE_HULA_QUEST_REWARD_MIN;
            UNACCEPTED_QUEST_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), questsData.UNACCEPTED_QUEST_COLOUR_STR);
            ACCEPTED_QUEST_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), questsData.ACCEPTED_QUEST_COLOUR_STR);
            NOT_TURNED_IN_QUEST_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), questsData.NOT_TURNED_IN_QUEST_COLOUR_STR);
            QUEST_BG_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), questsData.QUEST_BG_COLOUR_STR);

            // map data
            MAP_GRASS = mapData.MAP_GRASS;
            MAP_WATER = mapData.MAP_WATER;
            MAP_MOUNTAIN = mapData.MAP_MOUNTAIN;
            MAP_FOREST = mapData.MAP_FOREST;
            MAP_SAND = mapData.MAP_SAND;
            MAP_WOOD = mapData.MAP_WOOD;
            MAP_WALL = mapData.MAP_WALL;
            MAP_HOLE = mapData.MAP_HOLE;
            MAP_HOLE_FALSE = mapData.MAP_HOLE_FALSE;
            MAP_SHOP = mapData.MAP_SHOP;
            MAP_SHOP_RESTOCKING = mapData.MAP_SHOP_RESTOCKING;
            GRASS_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.GRASS_COLOUR_BG_STR);
            WATER_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.WATER_COLOUR_BG_STR);
            MOUNTAIN_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.MOUNTAIN_COLOUR_BG_STR);
            FOREST_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.FOREST_COLOUR_BG_STR);
            SAND_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.SAND_COLOUR_BG_STR);
            WOOD_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.WOOD_COLOUR_BG_STR);
            WALL_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.WALL_COLOUR_BG_STR);
            HOLE_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.HOLE_COLOUR_BG_STR);
            HOLE_FALSE_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.HOLE_FALSE_COLOUR_BG_STR);
            SHOP_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.SHOP_COLOUR_BG_STR);
            SHOP_RESTOCKING_COLOUR_BG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.SHOP_RESTOCKING_COLOUR_BG_STR);
            GRASS_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.GRASS_COLOUR_FG_STR);
            WATER_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.WATER_COLOUR_FG_STR);
            MOUNTAIN_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.MOUNTAIN_COLOUR_FG_STR);
            FOREST_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.FOREST_COLOUR_FG_STR);
            SAND_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.SAND_COLOUR_FG_STR);
            WOOD_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.WOOD_COLOUR_FG_STR);
            WALL_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.WALL_COLOUR_FG_STR);
            HOLE_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.HOLE_COLOUR_FG_STR);
            HOLE_FALSE_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.HOLE_FALSE_COLOUR_FG_STR);
            SHOP_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.SHOP_COLOUR_FG_STR);
            SHOP_RESTOCKING_COLOUR_FG = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), mapData.SHOP_RESTOCKING_COLOUR_FG_STR);

            // player and misc data
            PLAYER_CHAR = playerAndMiscData.PLAYER_CHAR;
            PLAYER_HP = playerAndMiscData.PLAYER_HP;
            PLAYER_STRENGTH = playerAndMiscData.PLAYER_STRENGTH;
            PLAYER_START_COINS = playerAndMiscData.PLAYER_START_COINS;
            START_X = playerAndMiscData.START_X;
            START_Y = playerAndMiscData.START_Y;
            CAMERA_RADIUS = playerAndMiscData.CAMERA_RADIUS;
            EVENT_LOG_LENGTH = playerAndMiscData.EVENT_LOG_LENGTH;
            CHARACTER_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), playerAndMiscData.CHARACTER_COLOUR_STR);
            ATTACK_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), playerAndMiscData.ATTACK_COLOUR_STR);
            PLAYER_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), playerAndMiscData.PLAYER_COLOUR_STR);
            PLAYER_ATTACKING_COLOUR = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), playerAndMiscData.PLAYER_ATTACKING_COLOUR_STR);
            PLAYER_DEFAULT_ATTACK_SHAPE = (AttackShape)Enum.Parse(typeof(AttackShape), playerAndMiscData.PLAYER_DEFAULT_ATTACK_SHAPE_STR);
        }
    }
}