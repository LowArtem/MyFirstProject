using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidKeyShop : MonoBehaviour {

    public GameObject NotMoney;

    public GameObject StandartMark;
    public GameObject BlueMark;
    public GameObject GreenMark;
    public GameObject RedMark;
    public GameObject GrayMark;
    public GameObject MulticolorouredMark;

    private string mode;

    void Update ()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                PauseFunk();
                return;
            }
        }
    }

    void PauseFunk()
    {
        NotMoney.SetActive(false);

        if (StandartMark.activeSelf)
        {
            mode = "standart";
        }
        else if (BlueMark.activeSelf)
        {
            mode = "blue";
        }
        else if (GreenMark.activeSelf)
        {
            mode = "green";
        }
        else if (RedMark.activeSelf)
        {
            mode = "red";
        }
        else if (GrayMark.activeSelf)
        {
            mode = "gray";
        }
        else if (MulticolorouredMark.activeSelf)
        {
            mode = "multicoloured";
        }

        MarksManager.StaticMode = mode;

        SceneManager.LoadScene("Menu");
    }
}
