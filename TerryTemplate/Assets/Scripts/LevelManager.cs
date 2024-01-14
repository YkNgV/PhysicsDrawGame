using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public Button[] button;

	// Initialization
	void Start() {
	//	Player.unlockedLevelIndex = PlayerPrefs.GetInt("Level");

		// Make all buttons except level 1 non-interactable
		if(PlayerPrefs.HasKey("Level")) {
			for(int i = 0; i < PlayerPrefs.GetInt("Level"); i++) {
				button[i].interactable = true;
				Debug.Log(i);
			}

			for(int i = 0; i < PlayerPrefs.GetInt("Level") + 1; i++) {
				button[i].GetComponent<LevelSelector>().lockImage[0].SetActive(false);
				button[i].GetComponent<LevelSelector>().lockImage[1].SetActive(true);
			}
		} else {
		//	for(int i = Player.unlockedLevelIndex + 1; i < button.Length; i++) {
		//		button[i].interactable = false;
		//		button[i].GetComponent<LevelSelector>().lockImage[0].SetActive(true);
		//		button[i].GetComponent<LevelSelector>().lockImage[1].SetActive(false);
		//	}
		}
	}

	void Update() {
		//if(Player.unlockedLevelIndex < button.Length) {
		//	for(int i = 0; i <= Player.unlockedLevelIndex; i++) {
		//		button[i].interactable = true;
		//	}
		//}
	}

	public void ClearData() {
		PlayerPrefs.DeleteAll();
		SceneManager.LoadScene("Main Menu");
	}
}