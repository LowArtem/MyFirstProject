using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviosBtn : MonoBehaviour
{
    public GameObject NotMoney;


    public GameObject StandartMark;
    public GameObject DesertMark;
    public GameObject ForestMark;
    public GameObject PlanetMark;
    public GameObject WinterForestMark;
    public GameObject CaveMark;

    private string mode2;


    public void OnMouseUp()
    {
        if (SceneManager.GetActiveScene().name == "Shop2")
        {
            NotMoney.SetActive(false);

            if (StandartMark.activeSelf)
            {
                mode2 = "standart";
            }
            else if (DesertMark.activeSelf)
            {
                mode2 = "desert";
            }
            else if (ForestMark.activeSelf)
            {
                mode2 = "forest";
            }
            else if (PlanetMark.activeSelf)
            {
                mode2 = "planet";
            }
            else if (WinterForestMark.activeSelf)
            {
                mode2 = "winterforest";
            }
            else if (CaveMark.activeSelf)
            {
                mode2 = "cave";
            }

            MarksManager.StaticMode2 = mode2;

            SceneManager.LoadScene("Shop");
        }
    }
}
