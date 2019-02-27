using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ForestBg : MonoBehaviour
{
    public GameObject Tablo;
    public GameObject NotMoney;
    public GameObject NotMoneyText;

    public GameObject StandartMark;
    public GameObject ForestMark;
    public GameObject DesertMark;
    public GameObject PlanetMark;
    public GameObject WinterForestMark;
    public GameObject CaveMark;

    private int money;
    private string info;
    private char[] ChArray;
    private bool isBuy = false;

    public void OnMouseDown()
    {
        NotMoney.SetActive(false);

        money = System.Convert.ToInt32(Tablo.GetComponent<Text>().text);


        FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData2.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        info = reader.ReadLine();

        reader.Close();

        file.Close();

        ChArray = info.ToCharArray();

        for (int i = 0; i < ChArray.Length; i++)
        {
            if (ChArray[i] == '1')
                isBuy = true;
        }

        if (!isBuy)
        {
            if (money >= 300)
            {
                money -= 300;

                Tablo.GetComponent<Text>().text = money.ToString();

                ForestMark.SetActive(true);

                StandartMark.SetActive(false);
                WinterForestMark.SetActive(false);
                DesertMark.SetActive(false);
                PlanetMark.SetActive(false);
                CaveMark.SetActive(false);

                FileStream file2 = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData2.txt", FileMode.Append, FileAccess.Write);

                StreamWriter writer = new StreamWriter(file2);

                writer.Write(1.ToString());

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
            ForestMark.SetActive(true);

            StandartMark.SetActive(false);
            WinterForestMark.SetActive(false);
            DesertMark.SetActive(false);
            PlanetMark.SetActive(false);
            CaveMark.SetActive(false);
        }

        File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", money.ToString());
    }
}
