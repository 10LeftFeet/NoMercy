using UnityEngine;
using System.Collections;

public class DDOL : MonoBehaviour {

	// Use this for initialization
	public void Awake () {
		DontDestroyOnLoad (gameObject);
	}

}
