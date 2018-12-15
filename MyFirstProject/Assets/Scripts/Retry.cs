using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public GameObject player1;

    public void OnMouseUp()
    {
        SceneManager.LoadScene("Game");
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
