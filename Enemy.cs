using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Enemy : GameCharacter
    {
        protected int moveCharge;
        protected int moveAt;
        protected EnemyTypeClass.EnemyType Type;
        protected Globals.EnemyAI AI;

        public Enemy(int x, int y, Map map, AttackMap attackMap, Render render) : base(x, y, map, attackMap, render)
        {
            moveCharge = 0;
            color = GameManager.globals.ENEMY_COLOUR;
            baseColor = color;
            attackColor = GameManager.globals.ENEMY_ATTACKING_COLOUR;
        }

        public override void Update()
        {
            base.Update();
            if (dead)
                return;
            moveCharge++;
            if (!MoveChargeCheck())
                return;
            MoveAI();
        }

        protected void MoveAI()
        {
            int[] playerPos = GameManager.GetPlayerPos();

            // attack
            switch (attackShape)
            {
                case var _ when attackShape == Globals.AttackShape.XAttack:
                    if (
                        ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 1)) ||
                        ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 1)))
                    {
                        Attack(attackShape);
                        return;
                    }
                    break;
                case var _ when attackShape == Globals.AttackShape.SpaceAttack:

                    if (x == playerPos[0] && y == playerPos[1])
                    {
                        Attack(attackShape);
                        return;
                    }
                    break;
                case var _ when attackShape == Globals.AttackShape.LongAttack:
                    if (
                        ((Math.Abs(playerPos[0] - x) == 0) && (Math.Abs(playerPos[1] - y) == 1)) ||
                        ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 0)) ||
                        ((Math.Abs(playerPos[0] - x) == 0) && (Math.Abs(playerPos[1] - y) == 2)) ||
                        ((Math.Abs(playerPos[0] - x) == 2) && (Math.Abs(playerPos[1] - y) == 0)))
                    {
                        Attack(attackShape);
                        return;
                    }
                    break;
                case var _ when attackShape == Globals.AttackShape.RingAttack:
                    if (
                        ((Math.Abs(playerPos[0] - x) == 0) && (Math.Abs(playerPos[1] - y) == 1)) ||
                        ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 0)))
                    {
                        Attack(attackShape);
                        return;
                    }
                    break;
                case var _ when attackShape == Globals.AttackShape.CrossAttack:
                    if (
                        ((Math.Abs(playerPos[0] - x) == 0) && (Math.Abs(playerPos[1] - y) == 1)) ||
                        ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 0)) ||
                        ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 1)) ||
                        ((Math.Abs(playerPos[0] - x) == 1) && (Math.Abs(playerPos[1] - y) == 1)))
                    {
                        Attack(attackShape);
                        return;
                    }
                    break;
            }

            // move
            switch (AI)
            {
                case var _ when AI == Globals.EnemyAI.Random:
                    switch (Globals.random.Next(4))
                    {
                        case 0:
                            yDelta--;
                            break;
                        case 1:
                            xDelta--;
                            break;
                        case 2:
                            yDelta++;
                            break;
                        case 3:
                            xDelta++;
                            break;
                    }
                    Move();
                    break;
                case var _ when AI == Globals.EnemyAI.Chase:
                    if (playerPos[0] > x)
                    {
                        xDelta++;
                        if (Move())
                        {
                            if (playerPos[1] > x)
                                yDelta++;
                            else if (playerPos[1] < y)
                                yDelta--;
                        }
                    }
                    else if (playerPos[0] < x)
                    {
                        xDelta--;
                        if (Move())
                        {
                            if (playerPos[1] > x)
                                yDelta++;
                            else if (playerPos[1] < y)
                                yDelta--;
                        }
                    }
                    else if (playerPos[1] > y)
                        yDelta++;
                    else if (playerPos[1] < y)
                        yDelta--;

                    Move();
                    break;
                case var _ when AI == Globals.EnemyAI.Static:
                    Attack(attackShape);
                    break;
            }
        }

        protected bool MoveChargeCheck()
        {
            if (moveCharge >= moveAt)
            {
                moveCharge = 0;
                return true;
            }
            return false;
        }

        protected override void Die()
        {
            base.Die();
        }

        public override void TakeDamage(int damageAmount, bool displayDamage = true)
        {
            if (attackMap.PlayerAttackCheck(x, y)) base.TakeDamage(damageAmount, displayDamage);
        }
        public void TakeDamageDirect(int damageAmount, bool displayDamage = true)
        {
            base.TakeDamage(damageAmount, displayDamage);
        }

        public EnemyTypeClass.EnemyType GetEnemyType()
        {
            return Type;
        }
    }
}