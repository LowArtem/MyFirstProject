using UnityEngine;

public class AndroidKeyMenu : MonoBehaviour {

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
        Application.Quit();
    }
}
