using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public SpriteRenderer circulo;
    public SpriteRenderer instrumento;


    public void ActivarSlot()
    {
        circulo.enabled = true;
    }
}
