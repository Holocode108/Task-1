using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMaps
{
  abstract class Unit : Object
  {
    protected int XPos;
    protected int YPos;
    protected int Health;
    protected int Mhealth;
    protected int Speed;
    protected int Attack;
    protected int RAttack;
    protected string Faction;
    protected bool IsAttacking;
    protected string symbol;

    public abstract void Move();
    public abstract void Combat();
    public abstract void AttackRange();
    public abstract void Death();
    public abstract void UnitInRange();
    public abstract override string ToString();

  }
}
