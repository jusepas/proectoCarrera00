using UnityEngine;
using System.Collections;

public class topomovement : MonoBehaviour {
	public Vector3 position;
	public bool left = false;
	public float velocity;


	// Use this for initialization
	void Start () {
		gameObject.transform.position = position;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (position.x >= 5f) {
			left = true;
		}
		if (position.x <= -5f) {
			left = false;
		}
		if (left == true) {

			position.x = position.x - velocity;
		} 
		else {
			position.x = position.x + velocity;
		}
		gameObject.transform.position = position;
	
	}
}
