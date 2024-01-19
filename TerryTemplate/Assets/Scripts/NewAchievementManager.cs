using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAchievementManager : MonoBehaviour
{

    public Text stars;
    public GameObject winText;
    public GameObject starUi;
    public int currentLevel;

    [Header("Star Requirement")]
    //public Text lineCountText;
    public int oneStar; //completely useless cus clear = 1 star anyways 
    public int twoStar;
    public int threeStar;

    NewLevelManager lvlManager;
    DrawingManager drawManager;

    private void Start()
    {   
        lvlManager = GetComponent<NewLevelManager>();
        drawManager = FindObjectOfType<DrawingManager>();
        winText.SetActive(false);
        starUi.SetActive(false);
        lvlManager.nextLvlButton.SetActive(false);
       
    }

    public void LevelCleared()
    {
        int reward; //number of stars to give

        if(drawManager.drawCount <= threeStar)
        {
            reward = 3;
        }
        else if(drawManager.drawCount <= twoStar)
        {
            reward = 2;
        }
        else
        {
            reward = 1;
        }


        



        //Player.reward = Random.Range(0, 4); // Minimum value is inclusive while maximum value is exclusive for integer data type
        winText.SetActive(true);
        starUi.SetActive(true);
        lvlManager.nextLvlButton.SetActive(true);

        lvlManager.restartButton.gameObject.SetActive(false);
        lvlManager.timeButton.gameObject.SetActive(false);
        stars.text = reward.ToString(); 
        
        //Debug.Log(reward); 
        if (currentLevel == lvlManager.unlockedLevel + 1 && lvlManager.unlockedLevel < 8) lvlManager.unlockedLevel++; // ensures cant spam 1 level over and over
        //if (lvlManager.unlockedLevel < 8) lvlManager.unlockedLevel++;

        //Debug.Log("Pre-index: " + Player.unlockedLevelIndex);
        PlayerPrefs.SetInt("Level", lvlManager.unlockedLevel);
        //PlayerPrefs.SetInt("Star" + lvlManager.unlockedLevel.ToString(), reward); //Star count for each level

        PlayerPrefs.SetInt("Star" + currentLevel.ToString(), reward); //set star rating
    }
}
