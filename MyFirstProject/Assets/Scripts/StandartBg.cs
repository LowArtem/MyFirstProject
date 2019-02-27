using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartBg : MonoBehaviour 
{
	public GameObject StandartMark;
    public GameObject DesertMark;
    public GameObject ForestMark;
    public GameObject PlanetMark;
    public GameObject WinterForestMark;
    public GameObject CaveMark;

    public GameObject NotMoney;

    public void OnMouseDown()
    {
        NotMoney.SetActive(false);

        StandartMark.SetActive(true);

        WinterForestMark.SetActive(false);
        DesertMark.SetActive(false);
        PlanetMark.SetActive(false);
        ForestMark.SetActive(false);
        CaveMark.SetActive(false);
    }
}
