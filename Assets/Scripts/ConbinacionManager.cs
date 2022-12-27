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
    public Slot slot1;
    public Slot slot2;
    public Slot slot3;
    public Slot slot4;


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

    public void ActivarSlot()
    {
        for (int i = 0; i < cantidad; i++)
        {
            
            slots[i].gameObject.SetActive(true);
        }
        Gm.gameTime = 7f;
    }

    void DesactivarSlots()
    {
        for (int i = 0; i < cantidad; i++)
        {
            slots[i].gameObject.SetActive(false);
            slot1.ResetearSlots();
            slot2.ResetearSlots();
            slot3.ResetearSlots();
            slot4.ResetearSlots();

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
        Gm.gameTime = 7f;


        secuencia.Clear();
        indiceSecuencia = -1;
        ElegirCantidad(4);
        ElegirInstrumento();
        ElegirPublico();
        DesactivarSlots();
        
    }

    void ElegirPublico()
    {
        publico.SeleccionarGente();
    }

    public void SeEquivoco(int _instrumentillo)
    {

        if (_instrumentillo != secuencia[indiceSecuencia])
        {
            secuencia.Clear();
        }
    }

}
