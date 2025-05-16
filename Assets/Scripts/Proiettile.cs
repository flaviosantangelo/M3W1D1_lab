using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Proiettile
{
    protected float velocita;
    public abstract void Lancia();

    public Proiettile(float velocita)
    {
        this.velocita = velocita;
    }
}
