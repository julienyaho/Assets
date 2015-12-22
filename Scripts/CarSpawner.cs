using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {
	
	public GameObject[] cars;
	int CarNo;
	public float maxPos = 1.1f;
	public float delayTimer = 0.5f;
	float timer;

	
	// Use this for initialization
	void Start () {
		timer = delayTimer;


	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPos = new Vector3 (Random.Range (-1.3f, 1.1f), transform.position.y, transform.position.z);
			CarNo = Random.Range (0,4);
			Instantiate (cars[CarNo], carPos, transform.rotation);
			timer = delayTimer;
		}


	}
}
