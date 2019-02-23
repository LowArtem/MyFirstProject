using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject drop;

    public int val;
    public int speed;

    public static int num;
    public static int speed_val;

    void Awake()
    {        
        DontDestroyOnLoad(transform.gameObject);        
    }

    void Update()
    {
        val = num;
        speed = speed_val;
    }   
}
