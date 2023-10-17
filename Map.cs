using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_RPG
{
    internal class Map
    {
        // LEGEND
        // ` - grass
        // ~ - water
        // ^ - mountain
        // * - forest
        // " - sand
        // = - wood
        // ▓ - Wall

        public char[,] map;

        public void Draw(Render render)
        {
            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    switch (map[i, j])
                    {
                        case var _ when map[i, j] == GameManager.globals.MAP_GRASS:
                            render.ChangeSpace(map[i, j], GameManager.globals.GRASS_COLOUR_BG, GameManager.globals.GRASS_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_SAND:
                            render.ChangeSpace(map[i, j], GameManager.globals.SAND_COLOUR_BG, GameManager.globals.SAND_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_FOREST:
                            render.ChangeSpace(map[i, j], GameManager.globals.FOREST_COLOUR_BG, GameManager.globals.FOREST_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_MOUNTAIN:
                            render.ChangeSpace(map[i, j], GameManager.globals.MOUNTAIN_COLOUR_BG, GameManager.globals.MOUNTAIN_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_WATER:
                            render.ChangeSpace(map[i, j], GameManager.globals.WATER_COLOUR_BG, GameManager.globals.WATER_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_WOOD:
                            render.ChangeSpace(map[i, j], GameManager.globals.WOOD_COLOUR_BG, GameManager.globals.WOOD_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_WALL:
                            render.ChangeSpace(map[i, j], GameManager.globals.WALL_COLOUR_BG, GameManager.globals.WALL_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_HOLE:
                            render.ChangeSpace(map[i, j], GameManager.globals.HOLE_COLOUR_BG, GameManager.globals.HOLE_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_HOLE_FALSE:
                            render.ChangeSpace(map[i, j], GameManager.globals.HOLE_FALSE_COLOUR_BG, GameManager.globals.HOLE_FALSE_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_SHOP:
                            render.ChangeSpace(map[i, j], GameManager.globals.SHOP_COLOUR_BG, GameManager.globals.SHOP_COLOUR_FG, j, i);
                            break;
                        case var _ when map[i, j] == GameManager.globals.MAP_SHOP_RESTOCKING:
                            render.ChangeSpace(map[i, j], GameManager.globals.SHOP_RESTOCKING_COLOUR_BG, GameManager.globals.SHOP_RESTOCKING_COLOUR_FG, j, i);
                            break;
                    }
                }
        }

        public bool IsWall(int x, int y, bool waterWalking)
        {
            try
            {
                switch (map[y, x])
                {
                    case var _ when map[y, x] == GameManager.globals.MAP_GRASS:
                    case var _ when map[y, x] == GameManager.globals.MAP_SAND:
                    case var _ when map[y, x] == GameManager.globals.MAP_FOREST:
                    case var _ when map[y, x] == GameManager.globals.MAP_WOOD:
                    case var _ when map[y, x] == GameManager.globals.MAP_SHOP:
                    case var _ when map[y, x] == GameManager.globals.MAP_SHOP_RESTOCKING:
                    case var _ when map[y, x] == GameManager.globals.MAP_HOLE_FALSE:
                        return false;
                    case var _ when map[y, x] == GameManager.globals.MAP_WATER:
                        if (waterWalking) return false;
                        return true;
                    case var _ when map[y, x] == GameManager.globals.MAP_MOUNTAIN:
                    case var _ when map[y, x] == GameManager.globals.MAP_WALL:
                    case var _ when map[y, x] == GameManager.globals.MAP_HOLE:
                    default:
                        return true;
                }
            }
            catch (Exception)
            {
                return true;
            }
        }

        public void FillSpace(int x, int y, Render render)
        {
            /*switch (map[y, x])
            {
                case '`':
                    render.ChangeSpace(map[y, x], ConsoleColor.Green, ConsoleColor.Black, x, y);
                    break;
                case '"':
                    render.ChangeSpace(map[y, x], ConsoleColor.Yellow, ConsoleColor.Black, x, y);
                    break;
                case '*':
                    render.ChangeSpace(map[y, x], ConsoleColor.DarkGreen, ConsoleColor.Black, x, y);
                    break;
                case '^':
                    render.ChangeSpace(map[y, x], ConsoleColor.DarkGray, ConsoleColor.Black, x, y);
                    break;
                case '~':
                    render.ChangeSpace(map[y, x], ConsoleColor.Blue, ConsoleColor.Black, x, y);
                    break;
            }*/
        }

        public Map()
        {
            string[] mapString = File.ReadAllLines("maps/Map.txt");
            map = new char[mapString.GetLength(0),mapString[0].Length];

            for (int i = 0; i < mapString.GetLength(0); i++)
                for (int j = 0; j < mapString[0].Length; j++)
                    map[i,j] = mapString[i][j];
        }

        public int Width()
        {
            return map.GetLength(1);
        }
        public int Height()
        {
            return map.GetLength(0);
        }

        public char GetChar(int x, int y)
        {
            return map[y,x];
        }
    }
}