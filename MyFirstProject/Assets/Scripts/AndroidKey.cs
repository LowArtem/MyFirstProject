using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidKey : MonoBehaviour
{
    public GameObject Play;
    public GameObject PauseScreen;
    public GameObject Text;
    public GameObject Retry;


    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                PauseFunk();
                return;
            }
        }
    }

    void PauseFunk()
    {
        if (!Player.lose)
        {
            if (Pause.pause)
            {
                PauseScreen.SetActive(false);
                Text.SetActive(false);
                Pause.pause = false;
                Play.SetActive(false);

                Retry.SetActive(false);

                Time.timeScale = 1;
            }
            else
            {
                Pause.pause = true;
                PauseScreen.SetActive(true);
                Play.SetActive(true);
                Retry.SetActive(true);
                Text.SetActive(true);
                Time.timeScale = 0;
            }           
        }
        else
        {
            Exit.exit = true;
            Player.lose = true;
            Pause.pause = false;
            Continue.isOff = false;
            Continue.isPress = 0;
            Time.timeScale = 1;

            SceneManager.LoadScene("Menu");
            return;
        }
        
    }
}
