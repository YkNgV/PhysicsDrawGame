using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {
	public int thisLevel;
	public Text levelText;
	public GameObject[] starImage;
	public GameObject[] lockImage;

	void Start() {
		levelText.text = thisLevel.ToString();

		if(PlayerPrefs.HasKey("Grade")) {
			if(PlayerPrefs.GetInt("Grade" + thisLevel.ToString()) == 0) {
				for(int i = 0; i <= 2; i++) {
					starImage[i].SetActive(false);
				}
			} else {
				for(int i = 1; i <= PlayerPrefs.GetInt("Grade" + thisLevel.ToString()); i++) {
					starImage[i - 1].SetActive(true);
				}
			}
		}

		//if(PlayerPrefs.HasKey("Level")) {
		//	for(int i = 0; i <= PlayerPrefs.GetInt("Level"); i++) {
		//		lockImage[0].SetActive(false);
		//		lockImage[1].SetActive(true);
		//	}
		//}
		//else {
		//	for(int i = 0; i < 3; i++) {
		//		starImage[i].SetActive(false);
		//	}
		//}
	}

	void Update() {
		if(thisLevel <= PlayerPrefs.GetInt("Level")) {
			//if(PlayerPrefs.HasKey("Star")) {
				for(int i = 0; i <= PlayerPrefs.GetInt("Star" + thisLevel.ToString()) - 1; i++) {
					starImage[i].SetActive(true);
				}
			//}
		}
	}

	public void OpenScene() {
		SceneManager.LoadScene("Level " + thisLevel.ToString());
	}
}