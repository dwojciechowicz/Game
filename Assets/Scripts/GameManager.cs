using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public GameObject deathMenu;
    public Text endScore;

    private void Start()
    {
        deathMenu.SetActive(false);
    }

    public void GameOver()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            float score = FindObjectOfType<PlayerMotion>().getScore();
            deathMenu.SetActive(true);
            endScore.text = ((int)score).ToString();
            //Invoke("Restart", 2);
        }
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

}

