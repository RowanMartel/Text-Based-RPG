﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Player : GameCharacter
    {
        EnemyManager enemyManager;
        NPCManager npcManager;
        int coins;

        public Player(int x, int y, Map map, AttackMap attackMap, Render render) : base(x, y, map, attackMap, render)
        {
            character = GameManager.globals.PLAYER_CHAR;
            color = GameManager.globals.PLAYER_COLOUR;
            attackColor = GameManager.globals.PLAYER_ATTACKING_COLOUR;
            baseColor = color;
            attackShape = GameManager.globals.PLAYER_DEFAULT_ATTACK_SHAPE;
            kamikaze = false;
            strength = GameManager.globals.PLAYER_STRENGTH;
            name = GameManager.globals.PLAYER_NAME;
            waterWalking = false;
            health = GameManager.globals.PLAYER_HP;
            maxHealth = GameManager.globals.PLAYER_HP;
            coins = GameManager.globals.PLAYER_START_COINS;
        }

        public override void Update()
        {
            base.Update();
            if (dead)
                return;

            TakeInput();
        }

        protected void TakeInput()
        {
            switch (GameManager.pressedKey)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    yDelta--;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    yDelta++;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    xDelta--;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    xDelta++;
                    break;
                case ConsoleKey.Spacebar:
                    Attack(attackShape);
                    break;
            }
            Move();
        }

        protected override void Attack(Globals.AttackShape attackShape)
        {
            base.Attack(attackShape);

            enemyManager.DamageEnemies();
            npcManager.NPCInteract();
        }

        public void GetNPCManager(NPCManager npcManager)
        {
            this.npcManager = npcManager;
        }

        public void GetEnemyManager(EnemyManager enemyManager)
        {
            this.enemyManager = enemyManager;
        }

        public void getBoat()
        {
            if (!waterWalking) waterWalking = true;
        }

        protected override void Die()
        {
            base.Die();
            GameManager.gameOver = true;
        }

        public int GetCoins()
        {
            return this.coins;
        }

        public void GiveCoins(int amount)
        {
            coins = amount + coins;
        }

        public bool TakeCoins(int amount)
        {
            if (coins - amount < 0)
                return false;

            coins = coins - amount;
            return true;
        }
    }
}