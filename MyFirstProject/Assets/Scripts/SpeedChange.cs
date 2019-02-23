using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class SpeedChange : MonoBehaviour
{
    private int dropval;

    public void Changed()
    {
        int temp = 0;
        temp = GetComponent<Dropdown>().value;

        Manager.num = temp;


        File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/DropDown.txt", temp.ToString());
    }

    public void Start()
    {
        /*int temp = 0;
        temp = GetComponent<Dropdown>().value;

        Manager.num = temp;


        File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/DropDown.txt", temp.ToString());*/


        FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/DropDown.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        dropval = Convert.ToInt32(reader.ReadLine());

        reader.Close();

        file.Close();

		this.GetComponent<Dropdown>().value = dropval;
    }
}
