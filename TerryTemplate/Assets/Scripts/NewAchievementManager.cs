using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAchievementManager : MonoBehaviour
{

    public Text stars;

    NewLevelManager lvlManager;

    private void Start()
    {
        lvlManager = GetComponent<NewLevelManager>();
    }

    public void LevelCleared()
    {
        //Player.reward = Random.Range(0, 4); // Minimum value is inclusive while maximum value is exclusive for integer data type
        //stars.text = Player.reward.ToString();
        //Debug.Log(Player.reward);

        if (lvlManager.unlockedLevel < 8) lvlManager.unlockedLevel++;

        //Debug.Log("Pre-index: " + Player.unlockedLevelIndex);
        PlayerPrefs.SetInt("Level", lvlManager.unlockedLevel);
        //PlayerPrefs.SetInt("Star" + lvlManager.unlockedLevel.ToString(), Player.reward);
    }
}
