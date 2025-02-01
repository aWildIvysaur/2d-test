using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] float panSpeed = 50f;
    private Controls controls;
    private Vector2 moveValue = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.Enable();
        controls.Camera.Move.performed += onMovePerformed;
        controls.Camera.Move.canceled += onMovecancelled;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(moveValue[0] * panSpeed * Time.deltaTime, moveValue[1] * panSpeed * Time.deltaTime, 0);

    }


    private void OnEnable() 
    {
        controls.Enable();
        controls.Camera.Move.performed += onMovePerformed;
        controls.Camera.Move.canceled += onMovecancelled;
    }
    private void  OnDisable()
    {
        controls.Disable();
        controls.Camera.Move.performed -= onMovePerformed;
        controls.Camera.Move.canceled -= onMovecancelled;
    }
    private void onMovePerformed(InputAction.CallbackContext value)
    {   
            moveValue = value.ReadValue<Vector2>();
    }
    private void onMovecancelled(InputAction.CallbackContext value)
    {
        moveValue = Vector2.zero;
    }
}
