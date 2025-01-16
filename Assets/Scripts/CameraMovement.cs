using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] float panSpeed = 50f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) //Up
		{
			transform.position = transform.position + new Vector3(0, panSpeed * Time.deltaTime, 0);
			
		}
        if(Input.GetKey(KeyCode.S)) //Down
		{
			transform.position = transform.position + new Vector3(0, -panSpeed * Time.deltaTime, 0);
			
		}

        if(Input.GetKey(KeyCode.A)) //Left
		{
			transform.position = transform.position + new Vector3(-panSpeed * Time.deltaTime, 0, 0);
			
		}
        if(Input.GetKey(KeyCode.D)) //Right
		{
			transform.position = transform.position + new Vector3(panSpeed * Time.deltaTime, 0, 0);
			
		}
    }
}
