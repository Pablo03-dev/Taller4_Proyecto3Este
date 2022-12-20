using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    //public Slider barrahp;

    public Slider barraTime;

    public TextMeshProUGUI timerText;
    public float gameTime;
    private bool stopTimer;
    public ConbinacionManager conbinacion;
    public GameObject laCombi;


    //private int score;
    //public Text scoreText;

    //public float timer = 10;
    //private bool juegoPausado = false;

    public GameoverScreen GameOverScreen;
    public bool completoSecuencia;

    private void Awake()
    {
        manager = this;
    //    score = 0;
    //    UpdatedScore();
    }

    

   public void GameOver()
    {
        print("EndGame");
        GameOverScreen.Setup(gameTime);
    }


    public void WinGame()
    {

    }

    public void ResetearJuego()
    {

    }

    public void QuitarTiempo()
    {

        //if (time < 0)
        //{
        //    GameOver();
        //}

    }

    void UpdatedScore()
    {
        //scoreText.text = "Score: " + score;
    }

    public void AddScore(int puntajesumaar)
    {
        //score += puntajesumaar;
        //Audiomanager.PlaySound("Coin");
        UpdatedScore();
    }

    private void Start()
    {
        stopTimer = false;
        barraTime.maxValue = gameTime;
        barraTime.value = gameTime;
    }

    private void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0)
        {
            stopTimer = true;
            GameOver();

        }

        if (stopTimer == false)
        {
            timerText.text = textTime;
            barraTime.value = time;
        }
    }



}
