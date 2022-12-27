using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameoverScreen : MonoBehaviour
{
    //public TMP_Text pointsText;
    private bool juegoPausado;


    private void Start()
    {
        juegoPausado = false;
    }

    public void Setup(float time)
    {
        gameObject.SetActive(true);

        juegoPausado = true;
        Pausa();
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        juegoPausado = true;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        juegoPausado = false;
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MenuPrincipal");
        Time.timeScale = 1f;
    }
}
