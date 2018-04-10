using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleSpawner : MonoBehaviour {


	public Transform ColorChangerPrefab;

	public Transform SmallCirclePrefab;

	public float SpawnLocation = 15f;

	
	public GameObject[] circleTypes;
	

	
	// Use this for initialization

	void Start () {
		for (int i = 0; i < 10; i++)
        {
            Instantiate(circleTypes[Random.Range(0, circleTypes.Length)], new Vector3(0, i * 10f, 0), Quaternion.identity);
			Instantiate(ColorChangerPrefab, new Vector3(0, i * 10f + 5f, 0), Quaternion.identity);
        }

		
	}
	
	
	


}
