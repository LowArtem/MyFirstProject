using UnityEngine;

public class MarksManager : MonoBehaviour
{
    public GameObject TestObject;

    public string mode;
    public static string StaticMode;

    public string mode2;
    public static string StaticMode2;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        if (StaticMode != null)
            mode = StaticMode;

        if (StaticMode2 != null)
            mode2 = StaticMode2;
    }
}
