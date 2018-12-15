using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject drop;

    public int val;

    public static int num;

    void Awake()
    {        
        DontDestroyOnLoad(transform.gameObject);        
    }

    void Update()
    {
        val = num;
    }   
}
