using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanciaProiettile : MonoBehaviour
{
    void Start()
    {
        List<Proiettile> listaProiettili = new List<Proiettile>();

        listaProiettili.Add(new Freccia(10f));
        listaProiettili.Add(new PallaMagica(5f));

        for (int i = 0; i < listaProiettili.Count; i++)
        {
            listaProiettili[i].Lancia();
        }
    }
}
