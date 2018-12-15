using UnityEngine;

public class FallDown : MonoBehaviour {

	[SerializeField]
	public float fallspeed = 2f;

	void Update () 
	{
		if (transform.position.y < -6f)
			Destroy (gameObject);

		transform.position -= new Vector3 (0, fallspeed * Time.deltaTime, 0);
	}
}
