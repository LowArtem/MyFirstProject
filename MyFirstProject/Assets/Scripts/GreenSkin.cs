﻿using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GreenSkin : MonoBehaviour
{
    public GameObject Tablo;
    public GameObject NotMoney;
    public GameObject NotMoneyText;

    public GameObject StandartMark;
    public GameObject BlueMark;
    public GameObject GreenMark;
    public GameObject RedMark;
    public GameObject GrayMark;
    public GameObject MulticolorouredMark;

    private int money;
    private string info;
    private char[] ChArray;
    private bool isBuy = false;

    public void OnMouseDown()
    {
        NotMoney.SetActive(false);

        money = System.Convert.ToInt32(Tablo.GetComponent<Text>().text);


        FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        info = reader.ReadLine();

        reader.Close();

        file.Close();

        ChArray = info.ToCharArray();

        for (int i = 0; i < ChArray.Length; i++)
        {
            if (ChArray[i] == '2')
                isBuy = true;
        }

        if (!isBuy)
        {
            if (money >= 300)
            {
                money -= 300;

                Tablo.GetComponent<Text>().text = money.ToString();

                GreenMark.SetActive(true);

                StandartMark.SetActive(false);
                GrayMark.SetActive(false);
                BlueMark.SetActive(false);
                RedMark.SetActive(false);
                MulticolorouredMark.SetActive(false);

                FileStream file2 = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData.txt", FileMode.Append, FileAccess.Write);

                StreamWriter writer = new StreamWriter(file2);

                writer.Write(2.ToString());

                writer.Close();

                file2.Close();

                isBuy = true;
            }
            else
            {
                NotMoneyText.GetComponent<Text>().text = "Not enough money. Need 300 to continue.";

                NotMoney.SetActive(true);
            }
        }
        else if (isBuy)
        {
            GreenMark.SetActive(true);

            StandartMark.SetActive(false);
            GrayMark.SetActive(false);
            BlueMark.SetActive(false);
            RedMark.SetActive(false);
            MulticolorouredMark.SetActive(false);
        }

        File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", money.ToString());
    }
}
