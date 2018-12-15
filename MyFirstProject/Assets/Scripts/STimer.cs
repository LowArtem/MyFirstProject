using UnityEngine;
using UnityEngine.UI;

public class STimer : MonoBehaviour
{

    public GameObject TimeCheck;

    private float Seconds = 0.0f;
    private int Minutes = 0;

    private string sSeconds;
    private string sMinutes;
    private string line;

    void Update()
    {
        if (!Player.lose)
        {
            Seconds = Seconds + Time.deltaTime;

            if (Seconds >= 60.0f)
            {
                Minutes++;
                Seconds = 0.0f;
            }

            if (Minutes < 10)
            {
                sMinutes = "0" + Minutes.ToString();
            }
            else
            {
                sMinutes = Minutes.ToString();
            }

            if (Seconds < 10)
            {
                sSeconds = "0" + Seconds.ToString();
            }
            else
            {
                sSeconds = Seconds.ToString();
            }

            line = sMinutes + ":" + sSeconds;

            TimeCheck.GetComponent<Text>().text = line.Replace(".", ":");
        }
    }
}