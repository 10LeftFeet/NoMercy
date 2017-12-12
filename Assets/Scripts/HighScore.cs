using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	public int score = 0;
	public int highScore = 0;
	string highScoreKey = "HighScore";
	private Text scoreText;
	private int totalScores = 5;

	void Start(){
		//Get the highScore from player prefs if it is there, 0 otherwise.
		highScore = PlayerPrefs.GetInt(highScoreKey,0);    
	}

	public void scoreCheck(){

		//If our scoree is greater than highscore, set new higscore and save.
		for (int i = 0; i < totalScores; i++) {

			highScoreKey = "HighScore" + (i + 1);
			highScore = PlayerPrefs.GetInt (highScoreKey, 0);

			if (score > highScore) {
				int temp = highScore;
				PlayerPrefs.SetInt (highScoreKey, score);
				score = temp;
				PlayerPrefs.Save ();
			}
		}
	}

}

