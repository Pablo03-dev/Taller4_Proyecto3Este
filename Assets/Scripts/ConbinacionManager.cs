using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConbinacionManager : MonoBehaviour
{

    //bombo = 0
    //caja = 1
    //platillo = 2
    //redoble = 3

    public Slot[] slots;
    int cantidad;
    public Sprite[] instrumentos;
    public List<int> secuencia = new List<int>();
    public int indiceSecuencia = 0;
    public Publico publico;
    public GameManager Gm;
    public GameObject globo;


    private void Start()
    {
        ElegirCantidad(4);
        ActivarSlot();
        ElegirInstrumento();
        ElegirPublico();
    }

    void ElegirCantidad(int _cantidad)
    {
        cantidad = _cantidad;
    }

    void ActivarSlot()
    {
        for (int i = 0; i < cantidad; i++)
        {
            slots[i].gameObject.SetActive(true);
        }
    }

    void DesactivarSlots()
    {
        for (int i = 0; i < cantidad; i++)
        {
            slots[i].gameObject.SetActive(false);
        }

        ActivarSlot();
    }

    void ElegirInstrumento()
    {
        for (int i = 0; i < cantidad; i++)
        {
            int instrumentoRandom = Random.Range(0, instrumentos.Length);
            slots[i].instrumento.sprite = instrumentos[instrumentoRandom];
            secuencia.Add(instrumentoRandom);

        }
    }

    public void ApretarInstrumento(int _instrumento)
    {
        if (_instrumento == secuencia[indiceSecuencia])
        {
            
            slots[indiceSecuencia].ActivarSlot();
            indiceSecuencia++;
            if (indiceSecuencia == cantidad)
            {
                CompletoSecuencia();
                if (indiceSecuencia < 4)
                {
                    indiceSecuencia++;
                }
            }
        }
    }


    void CompletoSecuencia()
    {
        //resetear la secuancia, 
        // resetear indiceSecuencia
        // apagar los slots
        // apagar los circulos
        GameManager.manager.completoSecuencia = true;
        print("Completo");

        indiceSecuencia = 0;

        secuencia.Clear();
        DesactivarSlots();
        ElegirCantidad(4);
        ActivarSlot();
        ElegirInstrumento();
        ElegirPublico();
    }

    void ElegirPublico()
    {
        publico.SeleccionarGente();
    }

    public void SeEquivoco(int _instrumentillo)
    {
        if (_instrumentillo != secuencia[indiceSecuencia])
        {
            ElegirCantidad(4);
            Debug.Log("sus");
        }
    }

}
