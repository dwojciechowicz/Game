using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public void GameOver()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("Game over!!!");
            Invoke("Restart", 1);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }

}

