using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour {

    private bool pause;
    public GameObject pauseMenu;

    public void Start() {
        pauseMenu.SetActive(false);
    }

    //Menu
    public void MainMenu () {
        SceneManager.LoadScene("MainMenu");
    }  

    //Resume Game
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);

    }

    //Pause Game
    public void PauseGame()
    {

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0;

    }
   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            if (pause)
                PauseGame();
            else
                ResumeGame();
        }
    }

}
