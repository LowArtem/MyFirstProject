using System.Collections;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coin;

    private int chanceDrop = 18;
    private float time;
    private float freetime;
    private GameObject BigManager;
    private int val;

    void Awake()
    {
        coin.GetComponent<CoinDown>().speed = 2;

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
            time = Random.Range(0.88f, 1.2f);
            coin.GetComponent<CoinDown>().speed = 2;
        }
        else if (val == 1) // скорость 5
        {
            freetime = Random.Range(0.70f, 1.1f);
            coin.GetComponent<CoinDown>().speed = 5;
        }
        else if (val == 2) // скорость 7
        {
            freetime = Random.Range(0.70f, 1.1f);
            coin.GetComponent<CoinDown>().speed = 7;
        }
        else if (val == 3)  // скорость 10
        {
            freetime = Random.Range(0.68f, 1.08f);
            coin.GetComponent<CoinDown>().speed = 10;
        }
    }

    void Start()
    {
        if (val == 0) // аркада
        {
            StartCoroutine(SpawnArcada());
        }
        else if (val == 1) // скорость 5
        {
            StartCoroutine(SpawnStaticSpeed());
        }
        else if (val == 2) // скорость 7
        {
            StartCoroutine(SpawnStaticSpeed());
        }
        else if (val == 3)  // скорость 10
        {
            StartCoroutine(SpawnStaticSpeed());
        }
    }

    IEnumerator SpawnArcada()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);

            if (Random.Range(0, 100) < chanceDrop)
            {
                CoinSpawn();
            }
        }
    }

    IEnumerator SpawnStaticSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(freetime);

            if (val == 3)
            {
                if (Random.Range(0, 100) < 19)
                {
                    CoinSpawn();
                }
            }
            else
            {
                if (Random.Range(0, 100) < 17)
                {
                    CoinSpawn();
                }
            }
        }
    }

    private void CoinSpawn()
    {
        Instantiate(coin, new Vector2(Random.Range(-2.5f, 2.5f), 6.0f), Quaternion.identity);
    }
}
