// Jason Huang 
// 300818592 
// This script allows the user to drag the weight up and down
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTon : MonoBehaviour {
	private Vector3 screenPoint;
	private Vector3 offset;

	void OnMouseDown(){
		screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	void OnMouseDrag(){
		Vector3 mousePoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint (mousePoint) + offset;
		transform.position = mousePosition;
		transform.position = new Vector3 (0, transform.position.y, transform.position.z);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
