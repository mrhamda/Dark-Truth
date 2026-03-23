using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManagerGamePlay : MonoBehaviour
{
    public string sceneName;
    public GameObject pauseMenu;
    PlayerMovement player;

    public GameObject settingsMenu;

    public AudioSource musicAudioSource;

    float musicVolume;
    float soundEffectVolume;

    public Slider soundEffectSlider;
    public Slider musicSlider;
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        soundEffectSlider.value = PlayerPrefs.GetFloat("SoundEffectVolume");

        player = GameObject.FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        musicVolume = musicSlider.value;
        soundEffectVolume = soundEffectSlider.value;

        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        PlayerPrefs.SetFloat("SoundEffectVolume", soundEffectVolume);

        musicAudioSource.volume = musicVolume;
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Lobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Resume()
    {
        player.paused = false;
    }
    public void Settings()
    {
        settingsMenu.SetActive(true);
    }
    public void Back()
    {
        settingsMenu.SetActive(false);
    }
    public void NextLevel()
    {
        if(sceneName == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }else if (sceneName == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (sceneName == "Level3")
        {
            SceneManager.LoadScene("Level4");
        }
        else if (sceneName == "Level4")
        {
            SceneManager.LoadScene("Level5");
        }
        else if (sceneName == "Level5")
        {
            SceneManager.LoadScene("Level6");
        }
        else if (sceneName == "Level6")
        {
            SceneManager.LoadScene("Level7");
        }
        else if (sceneName == "Level7")
        {
            SceneManager.LoadScene("Level8");
        }
        else if (sceneName == "Level8")
        {
            SceneManager.LoadScene("Level9");
        }
        else if (sceneName == "Level9")
        {
            SceneManager.LoadScene("Level10");
        }
    }
}
