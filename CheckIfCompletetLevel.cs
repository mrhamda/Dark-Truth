using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfCompletetLevel : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Check();
    }
    void Check()
    {
        if (sceneName == "Level1")
        {
            if (PlayerPrefs.GetString("Level1") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level2")
        {
            if (PlayerPrefs.GetString("Level2") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level3")
        {
            if (PlayerPrefs.GetString("Level3") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level4")
        {
            if (PlayerPrefs.GetString("Level4") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level5")
        {
            if (PlayerPrefs.GetString("Level5") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level6")
        {
            if (PlayerPrefs.GetString("Level6") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level7")
        {
            if (PlayerPrefs.GetString("Level7") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level8")
        {
            if (PlayerPrefs.GetString("Level8") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level9")
        {
            if (PlayerPrefs.GetString("Level9") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        else if (sceneName == "Level10")
        {
            if (PlayerPrefs.GetString("Level10") == "true")
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
}
