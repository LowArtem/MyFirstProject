using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public Sprite[] sprites = new Sprite[12];
	public GameObject player1;

    private GameObject BigManager;
    private string mode;

	public void OnMouseDown ()
	{
        if (GameObject.Find("MarksManager 1"))
        {
            BigManager = GameObject.Find("MarksManager 1");
            mode = BigManager.GetComponent<MarksManager>().mode;
        }
        else
        {
            mode = "standart";
        }

        if (mode == "standart")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[0];
        else if (mode == "blue")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[2];
        else if (mode == "green")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[4];
        else if (mode == "red")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[6];
        else if (mode == "gray")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[8];
        else if (mode == "multicoloured")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[10];

        SceneManager.LoadScene ("Game");
		Player.lose = false;
		Pause.pause = false;
        Exit.exit = false;
        Time.timeScale = 1;
        SpawnBombs.stop = true;
        Continue.isOff = false;
        Continue.isPress = 0;

        player1.GetComponent<SpriteRenderer>().sortingOrder = 1;

    }
}
