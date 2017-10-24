using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour {

	public void BackToMenu(){
		SceneManager.LoadScene ("Menu");

	}
}
