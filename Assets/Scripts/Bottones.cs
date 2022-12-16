using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottones : MonoBehaviour
{
    public GameObject Rojo;
    public GameObject Azul;
    public GameObject Verde;
    public GameObject Amarillo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Me Presionaron");
    }

    private void OnMouseDown()
    {
        Sonido();
    }

    public void Sonido()
    {
        Debug.Log("Me Presionaron");
    }
}
