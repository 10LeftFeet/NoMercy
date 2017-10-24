using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene ("Main");

	}
}
