using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private void Start()
    {
        if(PlayerPrefs.GetInt("debugmode",1)==0)
        GameObject.FindGameObjectWithTag("TButton").GetComponent<Toggle>().isOn = true;
        else
        GameObject.FindGameObjectWithTag("TButton").GetComponent<Toggle>().isOn = false;
    }
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
    public void ToggleChanged(bool state)
    {
        if(state)
        PlayerPrefs.SetInt("debugmode",0);
        else
        PlayerPrefs.SetInt("debugmode",1);
    }
}
