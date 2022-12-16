using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publico : MonoBehaviour
{
    public Gente[] gente;
    private int indicePersona;

    public void SeleccionarGente()
    {
        int random = Random.Range(0, gente.Length);

        for (int i = 0; i < gente.Length; i++)
        {
            if (i == random)
            {
                gente[i].Activar();
            }
            else
            {
                gente[i].Desactivar();
            }
        }
    }
}
