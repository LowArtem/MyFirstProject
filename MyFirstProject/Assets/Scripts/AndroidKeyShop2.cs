using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidKeyShop2 : MonoBehaviour
{
    public GameObject NotMoney;

    public GameObject StandartMark;
    public GameObject BlueMark;
    public GameObject GreenMark;
    public GameObject RedMark;
    public GameObject GrayMark;
    public GameObject MulticolorouredMark;

    private string mode2;

    void Update()
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
            mode2 = "standart";
        }
        else if (BlueMark.activeSelf)
        {
            mode2 = "desert";
        }
        else if (GreenMark.activeSelf)
        {
            mode2 = "forest";
        }
        else if (RedMark.activeSelf)
        {
            mode2 = "planet";
        }
        else if (GrayMark.activeSelf)
        {
            mode2 = "winterforest";
        }
        else if (MulticolorouredMark.activeSelf)
        {
            mode2 = "cave";
        }

        MarksManager.StaticMode2 = mode2;

        SceneManager.LoadScene("Menu");
    }
}
