using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject deathScreenCanvas;
    public void ShowDeathScreen()
    {
        deathScreenCanvas.SetActive(true);
        Debug.Log("hello");
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        Debug.Log("what");
        SceneManager.LoadScene("theActualGame");
    }
    private void Update()
    {
        Debug.Log(Time.timeScale);

    }
    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
    
}
