using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DevPreLoad : MonoBehaviour {


	void Awake () {
		Debug.Log ("checked");
		GameObject check = GameObject.Find ("_app");
		if (check == null) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("_preload", LoadSceneMode.Additive);
		}
	}

}
