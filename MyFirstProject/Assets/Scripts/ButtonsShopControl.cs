using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsShopControl : MonoBehaviour
{
    public GameObject btn_next;
    public GameObject btn_previos;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Shop2")
        {
            btn_next.GetComponent<Button>().interactable = false;
            btn_previos.GetComponent<Button>().interactable = true;
        }

        if (SceneManager.GetActiveScene().name == "Shop")
        {
            btn_previos.GetComponent<Button>().interactable = false;
            btn_next.GetComponent<Button>().interactable = true;
        }
    }
}
