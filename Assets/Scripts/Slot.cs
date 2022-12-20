using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public SpriteRenderer circulo;
    public SpriteRenderer instrumento;
    public ConbinacionManager CM;


    public void ActivarSlot()
    {
        circulo.enabled = true;
    }

    public void ResetearSlots()
    {
        circulo.enabled = false;

    }
}
