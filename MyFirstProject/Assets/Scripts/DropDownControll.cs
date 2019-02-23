using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class DropDownControll : MonoBehaviour
{

    private int dropval;
    public GameObject drop;

    void Start()
    {
        if (File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/DropDown.txt"))
        {
            FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/DropDown.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(file);

            dropval = Convert.ToInt32(reader.ReadLine());

            reader.Close();

            file.Close();

            drop.GetComponent<Dropdown>().value = dropval;
        }
    }
}
