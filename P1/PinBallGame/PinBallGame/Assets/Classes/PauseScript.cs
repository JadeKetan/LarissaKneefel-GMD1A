using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour
{

    public GameObject PauseMenu;
    public bool paused;
    public GameObject muteSoundNow;
    public bool muteToggle;
    public Text mutetext;
    


    void Start()
    {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
        
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;

        }
        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume()
    {
        paused = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Mute()
    {
        if (muteToggle == false)
        {
            muteSoundNow.SetActive(false);
            AudioListener.volume = 1;
            muteToggle = true;
        }

    }
    public void UnMute()
    {
        if (muteToggle == true)
        {
            muteSoundNow.SetActive(true);
            AudioListener.volume = 1;
            muteToggle = false;
        }

    }


    public void MainMenu()
    {
        Application.LoadLevel(0);

    }
        public void Restart()
    {
        PlayerPrefs.SetInt("currentsceneRestart", Application.loadedLevel);
    }

    public void Load()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("currentsceneRestart"));


    }

    public void Quit()
    {

        Application.Quit();
    }
}
