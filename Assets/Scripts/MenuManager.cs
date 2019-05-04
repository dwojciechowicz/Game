using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("highscore")).ToString();
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
}
