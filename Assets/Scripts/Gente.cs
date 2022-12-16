using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gente : MonoBehaviour
{
    public GameObject indicador;
    public bool activo;

public void Activar()
    {
        indicador.SetActive(true);
        activo = true;
    }



    public void Desactivar()
    {
        indicador.SetActive(false);
        activo = false;
    }

    private void OnMouseDown()
    {
        if (activo && GameManager.manager.completoSecuencia)
        {
            // feedback positivo
            GameManager.manager.completoSecuencia = false;
            Desactivar();

        }
        else
        {
            // penalizaciom
        }
    }
}
