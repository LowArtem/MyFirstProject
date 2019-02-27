using UnityEngine;

public class SelectMark2 : MonoBehaviour 
{

	public GameObject StandartMark;
    public GameObject DesertMark;
    public GameObject ForestMark;
    public GameObject PlanetMark;
    public GameObject WinterForestMark;
    public GameObject CaveMark;

    private GameObject BigManager;
    private string mode2 = "standart";

	void Start ()
    {
        if (GameObject.Find("MarksManager 1"))
        {
            BigManager = GameObject.Find("MarksManager 1");
            mode2 = BigManager.GetComponent<MarksManager>().mode2;
        }
        else
        {
            mode2 = "standart";
        }

        if (mode2 == "standart")
        {
            StandartMark.SetActive(true);

            WinterForestMark.SetActive(false);
            DesertMark.SetActive(false);
            PlanetMark.SetActive(false);
            ForestMark.SetActive(false);
            CaveMark.SetActive(false);
        }
        else if (mode2 == "desert")
        {
            DesertMark.SetActive(true);

            WinterForestMark.SetActive(false);
            StandartMark.SetActive(false);
            PlanetMark.SetActive(false);
            ForestMark.SetActive(false);
            CaveMark.SetActive(false);
        }
        else if (mode2 == "forest")
        {
            ForestMark.SetActive(true);

            WinterForestMark.SetActive(false);
            DesertMark.SetActive(false);
            PlanetMark.SetActive(false);
            StandartMark.SetActive(false);
            CaveMark.SetActive(false);
        }
        else if (mode2 == "planet")
        {
            PlanetMark.SetActive(true);

            WinterForestMark.SetActive(false);
            DesertMark.SetActive(false);
            StandartMark.SetActive(false);
            ForestMark.SetActive(false);
            CaveMark.SetActive(false);
        }
        else if (mode2 == "winterforest")
        {
            WinterForestMark.SetActive(true);

            StandartMark.SetActive(false);
            DesertMark.SetActive(false);
            PlanetMark.SetActive(false);
            ForestMark.SetActive(false);
            CaveMark.SetActive(false);
        }
        else if (mode2 == "cave")
        {
            CaveMark.SetActive(true);

            WinterForestMark.SetActive(false);
            DesertMark.SetActive(false);
            PlanetMark.SetActive(false);
            ForestMark.SetActive(false);
            StandartMark.SetActive(false);
        }
    }
}
