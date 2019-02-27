using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitShop : MonoBehaviour
{

    public GameObject NotMoney;

    public GameObject StandartMark;
    public GameObject BlueMark;
    public GameObject GreenMark;
    public GameObject RedMark;
    public GameObject GrayMark;
    public GameObject MulticolorouredMark;

    

    private string mode;
    private string mode2;

    public void OnMouseDown()
    {
        NotMoney.SetActive(false);

        if (SceneManager.GetActiveScene().name == "Shop")
        {
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
        }

        else if (SceneManager.GetActiveScene().name == "Shop2")
        {
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
        }

        SceneManager.LoadScene("Menu");
    }
}

