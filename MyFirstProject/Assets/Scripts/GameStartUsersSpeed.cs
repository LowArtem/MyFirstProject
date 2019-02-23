using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
using System;

public class GameStartUsersSpeed : MonoBehaviour
{

    public GameObject TextField;

    public void StartGame()
    {
        Player.lose = false;
        Pause.pause = false;
        Exit.exit = false;
        Time.timeScale = 1;
        SpawnBombs.stop = true;



        Manager.speed_val = Convert.ToInt32(TextField.GetComponent<Text>().text);


        

        SceneManager.LoadScene("Game");

        if (!Directory.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird"))
        {
            Directory.CreateDirectory(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird");
        }

        if (!File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", 0.ToString());
        }

        if (!File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/DropDown.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/DropDown.txt", 0.ToString());
        }

        if (!File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/MySpeed.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/MySpeed.txt", 10.ToString());
        }





        if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/MySpeed.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/MySpeed.txt", TextField.GetComponent<Text>().text);
        }
    }
}
