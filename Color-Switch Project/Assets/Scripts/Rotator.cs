using UnityEngine;

public class Rotator : MonoBehaviour {

	// to rotate 100 degrees every second
	public float speed = 100f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, 0f, speed * Time.deltaTime); // time.deltatime to even out the differencies in frame rate
	}
}
