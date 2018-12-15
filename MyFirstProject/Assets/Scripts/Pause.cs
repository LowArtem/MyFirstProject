using UnityEngine;

public class Pause : MonoBehaviour { 

	public GameObject Play;
	public GameObject PauseScreen;
	public GameObject Text;
    public GameObject Retry;

	public static bool pause = false;

	public void OnMouseDown()
	{
        if (!Player.lose)
        {
            pause = true;
            PauseScreen.SetActive(true);
            Play.SetActive(true);
            Retry.SetActive(true);
            Text.SetActive(true);
            Time.timeScale = 0;
        }
	}
}
