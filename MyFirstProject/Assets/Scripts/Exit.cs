using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {

    public static bool exit = false;

    public GameObject player1;

    private GameObject Manager2;

	public void OnMouseDown()
	{

        if (GameObject.Find("SceneManager 1"))
        {
            Manager2 = GameObject.Find("SceneManager 1");
            Manager2.GetComponent<Manager>().val = 0;
        }

        exit = true;
        Player.lose = true;
        Pause.pause = false;
        Continue.isOff = false;
        Continue.isPress = 0;
        Time.timeScale = 1;
        player1.GetComponent<SpriteRenderer>().sortingOrder = 1;
        SceneManager.LoadScene ("Menu");
    }
}
