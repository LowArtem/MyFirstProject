using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MoneyInShop : MonoBehaviour {

    public GameObject Tablo;

    private string info;

	void Start ()
    {
        FileStream file = new FileStream(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/Data.txt", FileMode.Open, FileAccess.Read);

        StreamReader reader = new StreamReader(file);

        info = reader.ReadLine();

        reader.Close();

        file.Close();

        Tablo.GetComponent<Text>().text = info;
    }
}
