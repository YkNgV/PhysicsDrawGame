using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewLevelManager : MonoBehaviour
{
    public Button[] button;
    public int unlockedLevel;

    // Start is called before the first frame update
    void Start()
    {

        if (SceneManager.GetActiveScene().name == "Level Select")
        {
           


            if (PlayerPrefs.HasKey("Level"))
            {


                Debug.Log("Lvl Select Active");

                for (int i = 0; i < PlayerPrefs.GetInt("Level"); i++)
                {
                    button[i].interactable = true;
                    Debug.Log(i);
                }

                for (int i = 0; i < PlayerPrefs.GetInt("Level") + 1; i++) //removed lock image based on unlocked level
                {
                    button[i].GetComponent<LevelSelector>().lockImage[0].SetActive(false); //locked
                    button[i].GetComponent<LevelSelector>().lockImage[1].SetActive(true);  //unlocked
                }
            }
            else
            {
                for (int i = unlockedLevel + 1; i < button.Length; i++) //if theres no prefab for level aka new game, set all locked
                {
                    button[i].interactable = false;
                    button[i].GetComponent<LevelSelector>().lockImage[0].SetActive(true);
                    button[i].GetComponent<LevelSelector>().lockImage[1].SetActive(false);
                }
            }
        }
        else
        {
            Debug.Log("returning");
            return;

        }
    }

    // Update is called once per frame
    void Update()
    {

        unlockedLevel = PlayerPrefs.GetInt("Level");

        if (SceneManager.GetActiveScene().name == "Level Select")
        {
            if (unlockedLevel < button.Length)
            {
                for (int i = 0; i <= unlockedLevel; i++)
                {
                    button[i].interactable = true;
                }
            }
        }
            

    }


    public void RestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ClearData()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Main Menu");
    }
}
