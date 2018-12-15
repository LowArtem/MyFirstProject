using System.Collections;
using UnityEngine;

public class DestroyParticle : MonoBehaviour {


	void Start ()
    {
        StartCoroutine(CoinParticle());
	}
	
    IEnumerator CoinParticle()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
