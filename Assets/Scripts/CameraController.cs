using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform camera;
    public float camSpeed = 3f;

    float camMovement_X; 
    float camMovement_Y;

    public Transform target;
    public Vector3 offset;
    private float targetDistance;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        targetDistance = Vector3.Distance(transform.position, target.position);
    }

    void LateUpdate()
    {
        // Camera control
        camMovement_Y = Input.GetAxisRaw("Mouse Y") * camSpeed;
        camMovement_X = Input.GetAxisRaw("Mouse X") * camSpeed;
        //Mathf.Clamp(transform.rotation.y, -60, 60);

        camera.Rotate(-camMovement_Y, camMovement_X, 0);
        //transform.eulerAngles = new Vector3(-camMovement_X, transform.eulerAngles.y + y, 0);
        Mathf.Clamp(transform.rotation.y, 60, -60); 
        Mathf.Clamp(transform.rotation.x, 60, -60);

        //camera.position = target.position - (transform.forward * targetDistance);
        //camera.LookAt(target.position);
        //camera.RotateAround(target.position, camMovement_X);
    }
}

