using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {
	[SerializeField] float zoomMult = 50f;
	// Use this for initialization
	void Start () {
		GetComponent<Camera>().orthographicSize = 6; // Size u want to start with
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetAxis("Mouse ScrollWheel") != 0) // Change From Q to anyother key you want
		{
			GetComponent<Camera>().orthographicSize = GetComponent<Camera>().orthographicSize + -zoomMult*Time.deltaTime * Input.GetAxis("Mouse ScrollWheel");
			if(GetComponent<Camera>().orthographicSize > 20)
			{
				GetComponent<Camera>().orthographicSize = 20; // Max size
			}
			else if(GetComponent<Camera>().orthographicSize < 1)
			{
				GetComponent<Camera>().orthographicSize = 1; // Min size 
			}
		}


		// if(Input.GetKey(KeyCode.E)) // Also you can change E to anything
		// {
		// 	GetComponent<Camera>().orthographicSize = GetComponent<Camera>().orthographicSize - 5*Time.deltaTime;
			
		// }
	}
}