using UnityEngine;
using System.Collections;

public class ScoreDeleteButton : MonoBehaviour {

	public void deleteScores(){
		PlayerPrefs.DeleteAll ();
	}
}
