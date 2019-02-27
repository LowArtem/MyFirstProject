using System;
using UnityEngine;
using System.IO;

public class BackgroundsControl : MonoBehaviour
{
    public GameObject DesertBg;
    public GameObject ForestBg;
    public GameObject PlanetBg;
    public GameObject WinterForestBg;
    public GameObject CaveBg;

    private GameObject BigManager;
    private string mode2;
    private int info;
    void Start()
    {
        /*if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))
        {
            FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", FileMode.Open, FileAccess.Read);

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
                MarksManager.StaticMode2 = "standart";
        }*/



        if (GameObject.Find("MarksManager 1"))
        {
            BigManager = GameObject.Find("MarksManager 1");
            mode2 = BigManager.GetComponent<MarksManager>().mode2;
        }
        else
        {
            mode2 = "standart";
        }



        if (mode2 == "standart")
        {
            DesertBg.SetActive(false);
            ForestBg.SetActive(false);
            PlanetBg.SetActive(false);
            WinterForestBg.SetActive(false);
            CaveBg.SetActive(false);

            /*if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))
                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", 0.ToString());*/
        }
        else if (mode2 == "desert")
        {
            DesertBg.SetActive(true);

            ForestBg.SetActive(false);
            PlanetBg.SetActive(false);
            WinterForestBg.SetActive(false);
            CaveBg.SetActive(false);

            /*/if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))
                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", 1.ToString());*/
        }
        else if (mode2 == "forest")
        {
            ForestBg.SetActive(true);

            DesertBg.SetActive(false);
            PlanetBg.SetActive(false);
            WinterForestBg.SetActive(false);
            CaveBg.SetActive(false);

            /*if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))
                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", 2.ToString());*/
        }
        else if (mode2 == "planet")
        {
            PlanetBg.SetActive(true);

            DesertBg.SetActive(false);
            ForestBg.SetActive(false);
            WinterForestBg.SetActive(false);
            CaveBg.SetActive(false);

            /*if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))
                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", 3.ToString());*/
        }
        else if (mode2 == "winterforest")
        {
            WinterForestBg.SetActive(true);

            DesertBg.SetActive(false);
            ForestBg.SetActive(false);
            PlanetBg.SetActive(false);
            CaveBg.SetActive(false);

            /*if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))

                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", 4.ToString());*/
        }
        else if (mode2 == "cave")
        {
            CaveBg.SetActive(true);

            DesertBg.SetActive(false);
            ForestBg.SetActive(false);
            PlanetBg.SetActive(false);
            WinterForestBg.SetActive(false);

            /*if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt"))
                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/SelectedBackground.txt", 5.ToString());*/
        }
    }
}
