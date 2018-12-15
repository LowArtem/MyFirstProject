using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SpawnBombs : MonoBehaviour
{

    public GameObject bomb;
    public GameObject coin;
    public GameObject M_camera;
    public GameObject Text1;
    public GameObject LevelText;
    public GameObject LevelPanel;
    public GameObject Tablo;
    public GameObject TimeTablo;
    public static bool stop = true;


    public float time = 1.2f;
    public float freetime = 0.7f;
    private int bombvalue = 0;
    private float complexity = 5;
    private float temp = 25;
    private int val;
    private int levelnum = 1;
    private GameObject BigManager;
    private const int lvl = 4;
    private int CoinVal = 0;
    private int chanceDrop = 7;
    private string SaveCoinInfo;



    void Awake()
    {
        bomb.GetComponent<FallDown>().fallspeed = 2;
        coin.GetComponent<CoinDown>().speed = 2;
        chanceDrop = 7;

        TimeTablo.SetActive(true);

        if (GameObject.Find("SceneManager 1"))
        {
            BigManager = GameObject.Find("SceneManager 1");
            val = BigManager.GetComponent<Manager>().val;
        }
        else
        {
            val = 0;
        }


        if (val == 0) // аркада
        {
            bomb.GetComponent<FallDown>().fallspeed = 2;
            coin.GetComponent<CoinDown>().speed = 2;
            time = 1.1f;
        }
        else if (val == 1) // скорость 5
        {
            bomb.GetComponent<FallDown>().fallspeed = 5;
            coin.GetComponent<CoinDown>().speed = 5;
        }
        else if (val == 2) // скорость 7
        {
            bomb.GetComponent<FallDown>().fallspeed = 7;
            coin.GetComponent<CoinDown>().speed = 7;
        }
        else if (val == 3)  // скорость 10
        {
            bomb.GetComponent<FallDown>().fallspeed = 10;
            coin.GetComponent<CoinDown>().speed = 10;
        }

    }

    void Start()
    {

        FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        SaveCoinInfo = reader.ReadLine();

        reader.Close();

        file.Close();


        Tablo.GetComponent<Text>().text = SaveCoinInfo;


        if (val == 0) // аркада
        {
            bomb.GetComponent<FallDown>().fallspeed = 2;
            coin.GetComponent<CoinDown>().speed = 2;
            time = 1.1f;

            StartCoroutine(SpawnArcada());
        }
        else if (val == 1) // скорость 5
        {
            freetime = 0.6f;
            chanceDrop = 7;

            StartCoroutine(SpawnStaticSpeed());
            LevelPanel.SetActive(false);
        }
        else if (val == 2) // скорость 7
        {
            freetime = 0.6f;
            chanceDrop = 7;

            StartCoroutine(SpawnStaticSpeed());
            LevelPanel.SetActive(false);
        }
        else if (val == 3) // скорость 10
        {
            freetime = 0.35f;
            chanceDrop = 8;

            StartCoroutine(SpawnStaticSpeed());
            LevelPanel.SetActive(false);
        }
    }

    IEnumerator SpawnArcada()
    {
        LevelPanel.SetActive(true);


        while (true)
        {
            if (bombvalue == complexity || bombvalue == complexity + 1)
            {
                if (bomb.GetComponent<FallDown>().fallspeed <= 11)
                {
                    bomb.GetComponent<FallDown>().fallspeed += 1;
                    coin.GetComponent<CoinDown>().speed += 1;

                    LevelText.GetComponent<Text>().text = (++levelnum).ToString();
                }
                else
                {
                    LevelText.GetComponent<Text>().text = (++levelnum).ToString();
                }

                if (time >= 0.35)
                {
                    time = time - 0.2f;
                }

                if (complexity >= 100)
                {
                    complexity += 52f;
                }
                else
                {
                    complexity *= 3f;
                }

                if (complexity >= temp)
                {
                    chanceDrop += 1;
                    temp *= 1.8f;
                }
            }

            Instantiate(bomb, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
            bombvalue++;

            if (Random.Range(0, 100) < 11)
            {
                Instantiate(bomb, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
                bombvalue++;
            }

            yield return new WaitForSeconds(time);

            if (Random.Range(0, 100) < chanceDrop)
            {
                CoinSpawn();
            }


            if (Player.lose)
            {
                CoinVal = System.Convert.ToInt32(Tablo.GetComponent<Text>().text);

                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", CoinVal.ToString());

                Time.timeScale = 0;
            }
        }
    }

    IEnumerator SpawnStaticSpeed()
    {
        LevelPanel.SetActive(false);


        while (true)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);

            if (Random.Range(0, 100) < 18)
            {
                Instantiate(bomb, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
            }

            yield return new WaitForSeconds(freetime);

            if (val == 3)
            {
                if (Random.Range(0, 100) < 8)
                {
                    CoinSpawn();
                }
            }
            else
            {
                if (Random.Range(0, 100) < 5)
                {
                    CoinSpawn();
                }
            }


            if (Player.lose)
            {
                CoinVal = System.Convert.ToInt32(Tablo.GetComponent<Text>().text);

                File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", CoinVal.ToString());

                Time.timeScale = 0;
            }
        }
    }

    public void CoinSpawn()
    {
        Instantiate(coin, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
    }
}