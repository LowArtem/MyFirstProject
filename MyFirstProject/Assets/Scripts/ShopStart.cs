using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class ShopStart : MonoBehaviour
{
    private int info;
    
    public void ShowShop()
    {
        SceneManager.LoadScene("Shop");


        if (!Directory.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird"))
        {
            Directory.CreateDirectory(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird");
        }

        if (!File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData.txt", 0.ToString());
        }

        if (!File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData2.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData2.txt", 0.ToString());
        }

        /*if (!File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", 0.ToString());
        }*/




        /*FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        info = Convert.ToInt32(reader.ReadLine());

        reader.Close();

        file.Close();

        if (info == 0)
            MarksManager.StaticMode2 = "standart";
        else if (info == 1)
            MarksManager.StaticMode2 = "desert";
        else if (info == 2)
            MarksManager.StaticMode2 = "forest";
        else if (info == 3)
            MarksManager.StaticMode2 = "planet";
        else if (info == 4)
            MarksManager.StaticMode2 = "winterforest";
        else if (info == 5)
            MarksManager.StaticMode2 = "cave";
        else
            MarksManager.StaticMode2 = "standart";*/
    }
}
