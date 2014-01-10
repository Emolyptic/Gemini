using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	GameObject playerObject;
	// Use this for initialization
	void Start () {
		playerObject = GameObject.Find("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3( playerObject.transform.position.x, playerObject.transform.position.y, -10);

	}
}
