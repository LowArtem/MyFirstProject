using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class ShopStart : MonoBehaviour {

	public void ShowShop()
    {
        SceneManager.LoadScene("Shop");


        if (!Directory.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird"))
        {
            Directory.CreateDirectory(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird");
        }

        if (!File.Exists(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData.txt"))
        {
            File.WriteAllText(@"/storage/emulated/0/Android/data/com.FirstGame.KindBird/ShopData.txt", 0.ToString());
        }
    }
}
