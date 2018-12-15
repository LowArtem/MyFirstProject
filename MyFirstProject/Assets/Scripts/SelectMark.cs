using UnityEngine;

public class SelectMark : MonoBehaviour {

    public GameObject StandartMark;
    public GameObject BlueMark;
    public GameObject GreenMark;
    public GameObject RedMark;
    public GameObject GrayMark;
    public GameObject MulticolorouredMark;

    private GameObject BigManager;
    private string mode = "standart";

	void Start ()
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

        if (mode == "standart")
        {
            StandartMark.SetActive(true);

            GrayMark.SetActive(false);
            BlueMark.SetActive(false);
            RedMark.SetActive(false);
            GreenMark.SetActive(false);
            MulticolorouredMark.SetActive(false);
        }
        else if (mode == "blue")
        {
            BlueMark.SetActive(true);

            GrayMark.SetActive(false);
            StandartMark.SetActive(false);
            RedMark.SetActive(false);
            GreenMark.SetActive(false);
            MulticolorouredMark.SetActive(false);
        }
        else if (mode == "green")
        {
            GreenMark.SetActive(true);

            GrayMark.SetActive(false);
            BlueMark.SetActive(false);
            RedMark.SetActive(false);
            StandartMark.SetActive(false);
            MulticolorouredMark.SetActive(false);
        }
        else if (mode == "red")
        {
            RedMark.SetActive(true);

            GrayMark.SetActive(false);
            BlueMark.SetActive(false);
            StandartMark.SetActive(false);
            GreenMark.SetActive(false);
            MulticolorouredMark.SetActive(false);
        }
        else if (mode == "gray")
        {
            GrayMark.SetActive(true);

            StandartMark.SetActive(false);
            BlueMark.SetActive(false);
            RedMark.SetActive(false);
            GreenMark.SetActive(false);
            MulticolorouredMark.SetActive(false);
        }
        else if (mode == "multicoloured")
        {
            MulticolorouredMark.SetActive(true);

            GrayMark.SetActive(false);
            BlueMark.SetActive(false);
            RedMark.SetActive(false);
            GreenMark.SetActive(false);
            StandartMark.SetActive(false);
        }
    }
}
