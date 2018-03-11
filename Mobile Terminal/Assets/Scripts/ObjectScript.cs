using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour {

	public GameObject model;
	public string id;
	public int timeToDestroy;

	// Use this for initialization
	void Start () {
		timeToDestroy = 20;
		model.transform.LookAt (Camera.main.transform.position, Vector2.up);
	}
	
	// Update is called once per frame
	void Update () {
		timeToDestroy--;
//		model.transform.LookAt (model.transform.position + Camera.main.transform.rotation * -Vector3.forward,
//			Camera.main.transform.rotation * Vector3.up);
//		if(timeToDestroy <= 0)
//			Destroy (model);
	}
}
