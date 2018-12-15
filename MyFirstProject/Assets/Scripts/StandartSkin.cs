using UnityEngine;

public class StandartSkin : MonoBehaviour
{
    public GameObject StandartMark;
    public GameObject BlueMark;
    public GameObject GreenMark;
    public GameObject RedMark;
    public GameObject GrayMark;
    public GameObject MulticolorouredMark;

    public GameObject NotMoney;

    public void OnMouseDown()
    {
        NotMoney.SetActive(false);

        StandartMark.SetActive(true);

        GrayMark.SetActive(false);
        BlueMark.SetActive(false);
        RedMark.SetActive(false);
        GreenMark.SetActive(false);
        MulticolorouredMark.SetActive(false);
    }
}
