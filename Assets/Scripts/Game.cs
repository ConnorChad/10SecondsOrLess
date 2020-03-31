using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    Spawner spawner;
    Timer timer;
    UIManager ui;
    public GameObject spawobj;
    public GameObject endGameUi;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    void Start()
    {
        timer = GameObject.Find("Canvas").GetComponent<Timer>();
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        ui = GameObject.Find("Canvas").GetComponent<UIManager>();

    }

   
    void Update()
    {
       if (timer.timer < 0)
        {
            spawobj.gameObject.SetActive(false);
            EndGame();
        }
    }

    void EndGame()
    {
       
        endGameUi.SetActive(true);
        ui.SetEndScore();
        Time.timeScale = 0f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(1);
      
    }
}
