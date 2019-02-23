using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidKeySpeedControl : MonoBehaviour {


	void Update () 
	{
		if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
				SceneManager.LoadScene("Menu");
			}
		}
	}
}
