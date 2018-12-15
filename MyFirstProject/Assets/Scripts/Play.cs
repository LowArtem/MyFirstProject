using UnityEngine;

public class Play : MonoBehaviour {

	public GameObject PauseScreen;
	public GameObject Play5;
	public GameObject Text;
    public GameObject Retry;

	public void OnMouseUp()
	{
        PauseScreen.SetActive (false);
		Text.SetActive (false);
		Pause.pause = false;
		Play5.SetActive (false);

        Retry.SetActive(false);

        Time.timeScale = 1;
    }
}
