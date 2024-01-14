using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAchievementManager : MonoBehaviour
{

    public Text stars;
    public GameObject winText;
    public GameObject starUi;

    NewLevelManager lvlManager;

    private void Start()
    {
        winText.SetActive(false);
        starUi.SetActive(false);
        lvlManager = GetComponent<NewLevelManager>();
    }

    public void LevelCleared()
    {
        int reward = 3; 
        //Player.reward = Random.Range(0, 4); // Minimum value is inclusive while maximum value is exclusive for integer data type
        winText.SetActive(true);
        starUi.SetActive(true);
        stars.text = reward.ToString();
        
        Debug.Log(reward);

        if (lvlManager.unlockedLevel < 8) lvlManager.unlockedLevel++;

        //Debug.Log("Pre-index: " + Player.unlockedLevelIndex);
        PlayerPrefs.SetInt("Level", lvlManager.unlockedLevel);
        PlayerPrefs.SetInt("Star" + lvlManager.unlockedLevel.ToString(), reward);
    }
}
