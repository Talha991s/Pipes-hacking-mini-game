using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EasyLevel()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void MediumLevel()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void HardLevel()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void RestartLevel1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void RestartLevel2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;

    }
    public void RestartLevel3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void backtomainmenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
