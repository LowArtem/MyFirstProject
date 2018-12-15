using UnityEngine;

public class CoinDown : MonoBehaviour {

	[SerializeField]
	public float speed = 2f;

	void Update () 
	{
		if (transform.position.y < -6f)
			Destroy (gameObject);

		transform.position -= new Vector3 (0, speed * Time.deltaTime, 0);
	}
}
