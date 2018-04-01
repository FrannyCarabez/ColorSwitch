using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;

	void Update()
	{
		// when the player passes the mid point of the camera,
		// the camera will move with the player.
		if (player.position.y > transform.position.y)
		{
			transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
		}
	}
}
