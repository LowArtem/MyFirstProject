using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{

    public GameObject PauseScreen;
    public GameObject RestartBtn;
    public GameObject Tablo;
    public GameObject ContinueBtn;
    public GameObject M_Camera;
    public GameObject player;
    public GameObject bomb;
    public GameObject NotMoney;
    public GameObject TextNotMoney;
    public Sprite[] sprites = new Sprite[12];
    public int price;

    public static bool isOff = false;
    public static int isPress = 0;

    private GameObject BigManager;
    private string mode;
    private int Info;


    public void OnMouseDown()
    {
        if (isPress != 2)
        {
            if (System.Convert.ToInt32(Tablo.GetComponent<Text>().text) >= price)
            {
                if (GameObject.Find("MarksManager 1"))
                {
                    BigManager = GameObject.Find("MarksManager 1");
                    mode = BigManager.GetComponent<MarksManager>().mode;
                }
                else
                {
                    mode = "standart";
                }

                FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(file);

                Info = System.Convert.ToInt32(reader.ReadLine());

                reader.Close();

                file.Close();


                Info = Info - price;


                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", Info.ToString());

                player.GetComponent<Player>().num = player.GetComponent<Player>().num - price;

                Tablo.GetComponent<Text>().text = Info.ToString();


                Player.lose = false;
                M_Camera.GetComponent<SpawnBombs>().enabled = true;


                if (mode == "standart")
                    player.GetComponent<SpriteRenderer>().sprite = sprites[0];
                else if (mode == "blue")
                    player.GetComponent<SpriteRenderer>().sprite = sprites[2];
                else if (mode == "green")
                    player.GetComponent<SpriteRenderer>().sprite = sprites[4];
                else if (mode == "red")
                    player.GetComponent<SpriteRenderer>().sprite = sprites[6];
                else if (mode == "gray")
                    player.GetComponent<SpriteRenderer>().sprite = sprites[8];
                else if (mode == "multicoloured")
                    player.GetComponent<SpriteRenderer>().sprite = sprites[10];


                Time.timeScale = 1;
                ContinueBtn.SetActive(false);
                PauseScreen.SetActive(false);
                RestartBtn.SetActive(false);
                player.GetComponent<SpriteRenderer>().sortingOrder = 1;

                isPress = isPress + 1;
                price = price * 2;

                if (isPress == 2)
                {
                    isOff = true;
                }
            }
            else
            {
                NotMoney.SetActive(true);
                TextNotMoney.GetComponent<Text>().text = "Not enough money. Need " + price + " to continue.";
            }
        }
    }
}
