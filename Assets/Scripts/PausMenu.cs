using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool paused;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();
            }
        }        
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    public void ReturnTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
