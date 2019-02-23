using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitSpeedControl : MonoBehaviour {

	void OnMouseDown()
    {
		SceneManager.LoadScene("Menu");
	}
}
