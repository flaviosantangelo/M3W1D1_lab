using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class Archer : Character
{
    public int damage = 7;
    public override void Attack()
    {
        int numeroAttacchi = 2;

        for (int i = 0; i < numeroAttacchi; i++)
        {
            Debug.Log(Nome + "scaglia la" + i.ToString() + "freccia e infligge" + damage);
        }
    }

    public override void TakeDamage(int dmg)
    {
        Vita -= dmg;
        Debug.Log(Nome + "prende" + dmg + "e rimane con" + Vita);

    }

    public Archer(string nome, int vita) : base(nome, vita)
    { 
    
    }

}