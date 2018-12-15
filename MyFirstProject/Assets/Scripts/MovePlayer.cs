using UnityEngine;


public class MovePlayer : MonoBehaviour 
{
	public Transform player;

	[SerializeField]
	private float speed = 12f;

	void OnMouseDrag ()
	{
		if (!Player.lose) {

			Vector3 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mousepos.x = mousepos.x > 2.5f ? 2.5f : mousepos.x;
			mousepos.x = mousepos.x < -2.5f ? -2.5f : mousepos.x;

			if (mousepos.x > player.position.x) 
			{
				player.transform.rotation = Quaternion.Euler (0, 180, 0);
			}

			if (mousepos.x < player.position.x)
			{
				player.transform.rotation = Quaternion.Euler (0, 0, 0);
			}

			player.position = Vector2.MoveTowards (player.position, 
				new Vector2 (mousepos.x, player.position.y),
				speed * Time.deltaTime);
		}
	}
}
