﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameStart : MonoBehaviour {

    
	public void ShowGame()
	{
        Player.lose = false;
        Pause.pause = false;
        Exit.exit = false;
        Time.timeScale = 1;
        SpawnBombs.stop = true;

        if(Manager.num == 4)
            SceneManager.LoadScene("Speed control");
        else
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
    }
}
