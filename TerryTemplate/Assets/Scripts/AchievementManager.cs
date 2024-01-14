using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour {
	public Text stars;
	

	void Start() {
		//if(PlayerPrefs.HasKey("Level")) {
		//	Player.unlockedLevelIndex = PlayerPrefs.GetInt("Level");
		//}
	}

	public void LevelCleared() {
	//	Player.reward = Random.Range(0, 4); // Minimum value is inclusive while maximum value is exclusive for integer data type
	//	stars.text = Player.reward.ToString();
	//	//Debug.Log(Player.reward);

	//	if(Player.unlockedLevelIndex < 8)
	//		Player.unlockedLevelIndex++;

		//Debug.Log("Pre-index: " + Player.unlockedLevelIndex);
	//	PlayerPrefs.SetInt("Level", Player.unlockedLevelIndex);
	//	PlayerPrefs.SetInt("Star" + Player.unlockedLevelIndex.ToString(), Player.reward);
	}
}