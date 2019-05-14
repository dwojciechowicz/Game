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
    public Text highScore;
    public TileSpawning ts;
    public PlayerMotion pm;

    private void Start()
    {
        deathMenu.SetActive(false);
        ts = FindObjectOfType<TileSpawning>();
        pm = FindObjectOfType<PlayerMotion>();
    }

    public void GameOver()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            float score = FindObjectOfType<PlayerMotion>().getScore();
            deathMenu.SetActive(true);
            endScore.text = ((int)score).ToString();
            if(score > PlayerPrefs.GetFloat("highscore"))
            PlayerPrefs.SetFloat("highscore", score);
            highScore.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("highscore")).ToString();
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
    public void Save()
    {
        SaveGame.SaveData(pm,ts);
    }
    public void Load()
    {
        PlayerData data = SaveGame.LoadData();
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        pm.rb.transform.position = position;
    }
}

