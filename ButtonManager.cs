using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject selectLevelMenu;
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject helpMenu;

    public AudioSource musicAudioSource;

    float musicVolume;
    float soundEffectVolume;

    public Slider soundEffectSlider;
    public Slider musicSlider;

   
    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        soundEffectSlider.value = PlayerPrefs.GetFloat("SoundEffectVolume");

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

    public void Play()
    {
        mainMenu.SetActive(false);
        selectLevelMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
    public void Settings()
    {
        mainMenu.SetActive(false);
        selectLevelMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void Back()
    {
        mainMenu.SetActive(true);
        selectLevelMenu.SetActive(false);
        settingsMenu.SetActive(false);
        helpMenu.SetActive(false);
    }

    public void Help()
    {
        mainMenu.SetActive(false);
        selectLevelMenu.SetActive(false);
        settingsMenu.SetActive(false);
        helpMenu.SetActive(true);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("Level7");
    }
    public void Level8()
    {
        SceneManager.LoadScene("Level8");
    }
    public void Level9()
    {
        SceneManager.LoadScene("Level9");
    }
    public void Level10()
    {
        SceneManager.LoadScene("Level10");
    }
  
}
