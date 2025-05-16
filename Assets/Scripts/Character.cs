using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string Nome { get; set; }
    public int Vita {  get; set; }

    public Character(string nome, int vita)
    {
        this.Nome = nome;
        this.Vita = vita;
    }

    public abstract void Attack();
    public abstract void TakeDamage(int damage);




}

  