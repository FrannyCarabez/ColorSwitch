﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	
	public float jumpForce = 10f;

	public Rigidbody2D rb;

	public Rigidbody2D ground;

	public SpriteRenderer sr;

	public string currentColor;

	public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;

	public Transform SmallCirclePrefab;
	public Transform ColorChangerPrefab;
	public Transform StarPrefab;

	public Vector3 Spawnlocation = new Vector3 (0, 800f, 0);

	
	void Start()
	{
		
		SetRandomColor();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.up * jumpForce;
			rb.constraints = ~RigidbodyConstraints2D.FreezePositionY;
		}

		

	}

	void OnTriggerEnter2D(Collider2D col) 
	{
		if (col.tag == "ColorChanger")
		{
			SetRandomColor();
			Destroy(col.gameObject);
			
			
			return;
		}

		if (col.tag == "Star")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

		else if(col.tag != currentColor)
		{
			// we hit a color which is not the same color of the player
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		
		
		
	}

	private void OnBecameInvisible() {
		if (rb.velocity.y < 0f)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void SetRandomColor()
	{
		// since i know how many colors the game will have, 
		// it will look at the index and for each index there will be a specific outcome.
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				sr.color = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
				break;
			case 2:
				currentColor = "Magenta";
				sr.color = colorMagenta;
				break;
			case 3:
				currentColor = "Pink";
				sr.color = colorPink;
				break;
		}
	}

	

	
		

	
}
