using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenasM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void Options()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void BacktoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
