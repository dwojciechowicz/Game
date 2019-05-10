using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighscoreManager : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        highScore.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("highscore")).ToString();
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ResetHighscore()
    {
        PlayerPrefs.SetFloat("highscore", 0);
    }
}
