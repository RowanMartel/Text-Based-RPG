using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Globals
    {
        // item value constants
        public int HEAL_SMALL;
        public int HEAL_LARGE = 5;
        public int SMALL_BOMB_DAMAGE = 5;

        // attack shape constants
        public int CROSS_ATTACK = 0;
        public int SPACE_ATTACK = 1;
        public int LONG_ATTACK = 2;
        public int RING_ATTACK = 3;
        public int X_ATTACK = 4;

        // character constants
        public char PLAYER_CHAR = '@';
        public char SHOP_CHAR = '$';
        public char GAMBLER_CHAR = '¢';
        public char QUEST_CHAR = '?';
        public char FISHERMAN_CHAR = 'F';
        public char MAYOR_CHAR = 'M';
        public char SOLDIER_CHAR = 'A';
        public char HERMIT_CHAR = 'H';
        public char GRASSGUY_CHAR = 'G';
        public char SANDGUY_CHAR = 'S';
        public char DOCKGUY_CHAR = 'D';
        public char SIGN_CHAR = 'P';
        public char JOURNAL_CHAR = 'J'; 
        public char ROAMER_CHAR = '0';
        public char CHARGER_CHAR = 'V';
        public char LAVA_CHAR = '₤';
        public char SWIMMER_CHAR = 'W';
        public char ELITE_CHAR = '‼';
        public char HEALTH_CHAR = '♥';
        public char HEALTH_CHAR2 = '+';
        public char COINBAG_CHAR = 'C';
        public char SPEAR_CHAR = '↑';
        public char BOMB_CHAR = 'B';
        public char BOAT_CHAR = 'U';
        public char HULA_CHAR = 'O';
        public char GEM_CHAR = '♦';

        // map display constants
        public char MAP_GRASS = '`';
        public char MAP_WATER = '~';
        public char MAP_MOUNTAIN = '^';
        public char MAP_FOREST = '*';
        public char MAP_SAND = '"';
        public char MAP_WOOD = '=';
        public char MAP_WALL = '▓';
        public char MAP_HOLE = 'n';
        public char MAP_HOLE_FALSE = 'f';
        public char MAP_SHOP = 'x';
        public char MAP_SHOP_R = 'r';

        // health constants
        public int PLAYER_HP = 10;
        public int ROAMER_HP = 2;
        public int CHARGER_HP = 1;
        public int LAVA_HP = 1;
        public int SWIMMER_HP = 3;
        public int ELITE_HP = 8;

        // coin constants
        public int PLAYER_START_COINS = 5;
        public int COINBAG_RANGE = 5;
        public int COINBAG_MIN = 3;
        public int HEALTH_COST = 4;
        public int HEALTH_COST2 = 8;
        public int SPEAR_COST = 15;
        public int BOMB_COST = 60;
        public int BOAT_COST = 40;
        public int HULA_COST = 20;
        public int GEM_COST = 100;
        public int COINBAG_COST = 5;

        // quest char constants
        public char UNACCEPTED_QUEST = '?';
        public char ACCEPTED_QUEST = '?';
        public char NOT_TURNED_IN_QUEST = '!';
        public char RANDOM_QUEST_CHAR = 'R';
        public char GIVE_HEALTH_QUEST_CHAR = 'H';
        public char GIVE_SPEAR_QUEST_CHAR = 'S';
        public char GIVE_HULA_QUEST_CHAR = 'O';

        // quest reward constants
        public int GIVE_HEALTH_QUEST_REWARD_RANGE = 4;
        public int GIVE_HEALTH_QUEST_REWARD_MIN = 5;
        public int GIVE_SPEAR_QUEST_REWARD_RANGE = 6;
        public int GIVE_SPEAR_QUEST_REWARD_MIN = 13;
        public int GIVE_HULA_QUEST_REWARD_RANGE = 6;
        public int GIVE_HULA_QUEST_REWARD_MIN = 13;

        // move-at constants
        public int ROAMER_MOVEAT = 2;
        public int CHARGER_MOVEAT = 1;
        public int LAVA_MOVEAT = 1;
        public int SWIMMER_MOVEAT = 2;
        public int ELITE_MOVEAT = 2;

        // strength constants
        public int PLAYER_STRENGTH = 1;
        public int ROAMER_STRENGTH = 1;
        public int CHARGER_STRENGTH = 3;
        public int LAVA_STRENGTH = 3;
        public int SWIMMER_STRENGTH = 2;
        public int ELITE_STRENGTH = 4;

        // random class constant
        public static Random random = new Random();

        // player starting position
        public int START_X = 54;
        public int START_Y = 39;

        // camera radius
        public int CAMERA_RADIUS = 10;

        // event log length
        public int EVENT_LOG_LENGTH = 7;

        public void LoadAllData()
        {
            // items data
            string itemsDataPath = "Items_data";
            string itemsJsonData = File.ReadAllText(itemsDataPath);
            var itemsData = JsonSerializer.Deserialize<Globals>(itemsJsonData);

            CopySettings(itemsData);
        }

        private void CopySettings(Globals itemsData)
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
        }
    }
}