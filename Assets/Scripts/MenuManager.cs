using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    
    // Start is called before the first frame update
   
    public void ToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ToHighscore()
    {
        SceneManager.LoadScene("Highscore");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
