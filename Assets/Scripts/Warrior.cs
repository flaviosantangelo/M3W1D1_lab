using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Warrior : Character
{
    int damage = 10;
    public Warrior(string nome, int vita) : base(nome, vita)
    {

    }
    
    public override void Attack()
    {
        
        Debug.Log(Nome + "ha inflitto" + damage);

    }

    public override void TakeDamage(int dmg)
    {
        Vita -= damage;
        Debug.Log(Nome + "prende" + damage + "e rimane con" + Vita);

    }
}
