using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CameraZoom : MonoBehaviour {
	[SerializeField] float zoomMult = 50f;
	// Use this for initialization
	private Controls controls;
	private float zoomAxis = 0;
	void Start () 
	{
		controls = new Controls();
        controls.Enable();
        controls.Camera.Zoom.performed += onZoomPerformed;
        controls.Camera.Zoom.canceled += onZoomcancelled;
	}

	void onZoomPerformed(UnityEngine.InputSystem.InputAction.CallbackContext value)
	{
		zoomAxis = value.ReadValue<float>();
	}

	void onZoomcancelled(UnityEngine.InputSystem.InputAction.CallbackContext value)
	{
		zoomAxis = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{

		GetComponent<Camera>().orthographicSize = GetComponent<Camera>().orthographicSize + zoomMult * Time.deltaTime * zoomAxis;
		if(GetComponent<Camera>().orthographicSize > 20)
		{
			GetComponent<Camera>().orthographicSize = 20; // Max size
		}
		else if(GetComponent<Camera>().orthographicSize < 1)
		{
			GetComponent<Camera>().orthographicSize = 1; // Min size 
		}
		
	}
}