using UnityEngine;
using UnityEngine.UI;

public class SpeedChange : MonoBehaviour {
    
	public void Changed()
    {
        int temp = 0;
        temp = GetComponent<Dropdown>().value;

        Manager.num = temp;
    }

    public void Start()
    {
        int temp = 0;
        temp = GetComponent<Dropdown>().value;

        Manager.num = temp;
    }
}
