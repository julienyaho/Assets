using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float carSpeed; // this take control of the car
	public float maxPos = 1.1f;

	Vector3 position;
	public UiManager ui;

	// Use this for initialization
	void Start () {
		//ui = GetComponent<UiManager> ();
		position = transform.position; // this is the current position of the the car
	
	}
	
	// Update is called once per frame
	void Update () {

		position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime; //this is the input for the left and right arrow key
		position.x = Mathf.Clamp (position.x, -1.4f, 1.1f);

		transform.position = position;
	
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
		Destroy (gameObject);
			ui.gameoverActivated();

		}
	}
}