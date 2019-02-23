using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class MySpeedControll : MonoBehaviour
{
    private int spd;
	public GameObject TextField;

    void Start()
    {
        if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/MySpeed.txt"))
        {
            FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/MySpeed.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(file);

            spd = Convert.ToInt32(reader.ReadLine());

            reader.Close();

            file.Close();

            TextField.GetComponent<InputField>().text = spd.ToString();
        }
    }

}
