using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    //public Slider barrahp;
    private int score;
    public TextMeshProUGUI scoreText;
    public GameoverScreen GameOverScreen;

    public Slider barraTime;

    public TextMeshProUGUI timerText;
    public float gameTime;
    public float OriginTime;
    private bool stopTimer;
    public ConbinacionManager conbinacion;
    public GameObject laCombi;

    public bool completoSecuencia;

    private void Awake()
    {
        manager = this;
        score = 0;
        UpdatedScore();
    }

    

   public void GameOver()
    {
        print("EndGame");
        GameOverScreen.Setup(score);
    }


    void UpdatedScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int puntajesumaar)
    {
        score += puntajesumaar;
        //Audiomanager.PlaySound("Coin");
        UpdatedScore();
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        Time.timeScale = 1;
        gameTime = OriginTime;
        stopTimer = false;
        barraTime.maxValue = gameTime;
        barraTime.value = gameTime;
    }

    private void Update()
    {



        float time = gameTime -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0)
        {
            stopTimer = true;
            GameOver();

        }

        if (gameTime >= 5)
        {
            gameTime = OriginTime;
        }

        if (stopTimer == false)
        {
            timerText.text = textTime;
            barraTime.value = time;
        }

        if (completoSecuencia == true)
        {
            gameTime += 5;
            completoSecuencia = false;
        }

        


    }



}
