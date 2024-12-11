using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy
{
    public string EnemyName;

    public virtual void Attack()
    {
        Debug.Log(EnemyName + " attacks!");
    }

}

public class Dragon : Enemy
{

    public override void Attack()
    {
        Debug.Log(EnemyName + " attacks!");
    }
    public virtual void Fly()
    {
        Debug.Log(EnemyName + "fly!");
    }
}

public class Snake : Enemy
{

    public override void Attack()
    {
        Debug.Log(EnemyName + " attacks!");
    }
    public virtual void Move()
    {
        Debug.Log(EnemyName + "move!");
    }
}

public class Fish : Enemy
{

    public override void Attack()
    {
        Debug.Log(EnemyName + " attacks!");
    }
    public virtual void Swim()
    {
        Debug.Log(EnemyName + "swim!");
    }
}



