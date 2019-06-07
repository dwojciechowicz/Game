using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject info;
    private void Start()
    {
        info.SetActive(false);
        if(PlayerPrefs.GetInt("debugmode",1)==0)
        GameObject.FindGameObjectWithTag("TButton").GetComponent<Toggle>().isOn = true;
        else
        GameObject.FindGameObjectWithTag("TButton").GetComponent<Toggle>().isOn = false;
    }
    public void ToLevel1()
    {
        ToLevelScene tls = new ToLevelScene();
        tls.ToLevel1();
    }
    public void ToHighscore()
    {
        ToHighscoreScene ths = new ToHighscoreScene();
        ths.ToHighscore();
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
    public void Information()
    {
        if (info.activeSelf.Equals(false))
            info.SetActive(true);
        else
            info.SetActive(false);
    }
}
public class ToHighscoreScene
{
    public void ToHighscore()
    {
        SceneManager.LoadScene("Highscore");
    }
}
public class ToLevelScene
{
    public void ToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
}