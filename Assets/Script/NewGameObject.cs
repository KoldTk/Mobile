using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class Weapon
{
    public int CalculateDamage(int baseDamage, int bonusDamage)
    {
        return baseDamage + bonusDamage;
    }
    public float CalculateDamage(float baseDamage, float multiplier)
    {
        return baseDamage * multiplier;
    }
    public int CalculateDamage(int baseDamage, int bonusDamage, int criticalHit)
    {
        return (baseDamage + bonusDamage) * criticalHit;
    }

}

public class NewGameObject : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Weapon sword = new Weapon();
        Debug.Log("CalculateDamage(int, int): " + sword.CalculateDamage(10, 5));
        Debug.Log("CalculateDamage(float, float): " + sword.CalculateDamage(10.5f, 12.5f));
        Debug.Log("CalculateDamage(int, int, int): " + sword.CalculateDamage(10, 5, 2));

        EnemyClass orc = new Orc();
        EnemyClass troll = new Troll();
        EnemyClass wizard = new Wizard();
        wizard.Attack();
        orc.Attack();
        troll.Attack();

        WeaponClass swordDamage = new SwordClass(10);
        WeaponClass bowDamage = new BowClass(8, 15);
        swordDamage.AttackWeapon();
        bowDamage.AttackWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

public class EnemyClass
{
    public virtual void Attack()
    {
        Debug.Log("Enemy attacks!");
    }
}

public class Orc : EnemyClass
{
    public override void Attack()
    {
        Debug.Log("Orc swings a massive club!");
    }
}
public class Troll : EnemyClass
{
    public override void Attack()
    {
        Debug.Log("Troll smashes with its fists!");
    }
}

public class Wizard : EnemyClass
{
    public override void Attack()
    {
        Debug.Log("Wizard shoots beam!");
    }
}

public abstract class WeaponClass
{
    public abstract void AttackWeapon();
}

public class SwordClass : WeaponClass
{
    private int damage;
    public SwordClass(int damage)
    {
        this.damage = damage;
    }
    public override void AttackWeapon()
    {
        Debug.Log("Sword attack deals " + damage + " damage.");
    }
}

public class BowClass : WeaponClass
{
    private int damage;
    private int range;
    public BowClass(int damage, int range)
    {
        this.damage = damage;
        this.range = range;
    }
    public override void AttackWeapon()
    {
        Debug.Log("Bow attack deals " + damage + " damage from " + range + " meters away.");
    }
}
