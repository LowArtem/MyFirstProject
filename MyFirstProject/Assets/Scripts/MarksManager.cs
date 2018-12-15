using UnityEngine;

public class MarksManager : MonoBehaviour
{
    public GameObject TestObject;

    public string mode;
    public static string StaticMode;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        mode = StaticMode;
    }
}
