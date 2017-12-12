using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic; 		//Allows us to use Lists.


public class ScoreList : MonoBehaviour {

	public int highScore;
	string highScoreKey = "HighScore";
	public Text[] scoreText;

	void Update(){
		for (int i = 0; i < 5; i++){
			highScoreKey = "HighScore" + (i + 1);
			highScore = PlayerPrefs.GetInt(highScoreKey,0);
			scoreText [i].text = (i+1) + ") " + highScore + " days";
		//use this value in whatever shows the leaderboard.

		}
	}

}
