using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Sprite[] sprites = new Sprite[12];

    public GameObject restart;
    public GameObject PauseScreen;
    public GameObject player1;
    public GameObject tablo;
    public GameObject coin;
    public GameObject particle;
    public GameObject ContinueBtn;


    public int num = 0;
    public static bool lose = false;

    private string Info;
    private GameObject BigManager;
    private string mode;


    void Awake()
    {
        FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        Info = reader.ReadLine();

        reader.Close();

        file.Close();


        num = System.Convert.ToInt32(Info);

        player1.GetComponent<SpriteRenderer>().sortingOrder = 1;


        if (GameObject.Find("MarksManager 1"))
        {
            BigManager = GameObject.Find("MarksManager 1");
            mode = BigManager.GetComponent<MarksManager>().mode;
        }
        else
        {
            mode = "standart";
        }


        if (mode == "standart")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[0];
        else if (mode == "blue")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[2];
        else if (mode == "green")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[4];
        else if (mode == "red")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[6];
        else if (mode == "gray")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[8];
        else if (mode == "multicoloured")
            player1.GetComponent<SpriteRenderer>().sprite = sprites[10];
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        Info = reader.ReadLine();

        reader.Close();

        file.Close();


        if (other.gameObject.tag == "Bomb")
        {
            lose = true;

            Time.timeScale = 0;


            if (mode == "standart")
                player1.GetComponent<SpriteRenderer>().sprite = sprites[1];
            else if (mode == "blue")
                player1.GetComponent<SpriteRenderer>().sprite = sprites[3];
            else if (mode == "green")
                player1.GetComponent<SpriteRenderer>().sprite = sprites[5];
            else if (mode == "red")
                player1.GetComponent<SpriteRenderer>().sprite = sprites[7];
            else if (mode == "gray")
                player1.GetComponent<SpriteRenderer>().sprite = sprites[9];
            else if (mode == "multicoloured")
                player1.GetComponent<SpriteRenderer>().sprite = sprites[11];


            Destroy(other.gameObject);

            restart.SetActive(true);


            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", tablo.GetComponent<Text>().text);


            var BObj = GameObject.FindGameObjectsWithTag("Bomb");
            for (int i = 0; i < BObj.Length; i++)
            {
                Destroy(BObj[i]);
            }

            var CObj = GameObject.FindGameObjectsWithTag("Coin");
            for (int i = 0; i < CObj.Length; i++)
            {
                Destroy(CObj[i]);
            }

            var PObj = GameObject.FindGameObjectsWithTag("CoinParticle");
            for (int i = 0; i < PObj.Length; i++)
            {
                Destroy(PObj[i]);
            }


            if (!Continue.isOff)
            {
                //player1.GetComponent<SpriteRenderer>().sortingOrder = -1;
                ContinueBtn.SetActive(true);
            }
            else
            {
                ContinueBtn.SetActive(false);
            }

            PauseScreen.SetActive(true);
        }

        if (other.gameObject.tag == "Coin")
        {
            if (!lose)
            {
                num = num + 1;

                tablo.GetComponent<Text>().text = num.ToString();

                Instantiate(particle, transform.position, transform.rotation);

                Destroy(other.gameObject);
            }
        }
    }
}
