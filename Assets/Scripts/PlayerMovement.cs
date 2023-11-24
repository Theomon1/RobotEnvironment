using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 5f;

    public float camSpeed = 5f;
    float camMovement_X;
    float camMovement_Y;

    CharacterController characterController;
    Camera playerCam;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerCam = Camera.main;
    }

    void LateUpdate()
    {
        // Movement 
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) // Move forwards
        {
            characterController.Move(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) // Move back
        {
            characterController.Move(-(transform.forward * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // Move right
        {
            characterController.Move(transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // Move left
        {
            characterController.Move(-(transform.right * speed * Time.deltaTime));
        }

        // Camera control
        //float y = Input.GetAxisRaw("Mouse X") * camSpeed;
        //camMovement_X = Input.GetAxisRaw("Mouse Y") * camSpeed;
        //Mathf.Clamp(transform.rotation.y, -60, 60);

        //transform.Rotate(camMovement_X, camMovement_Y, 0);
        //transform.eulerAngles = new Vector3(-camMovement_X, transform.eulerAngles.y + y, 0);
        //Mathf.Clamp(transform.rotation.y, -60, 60);

    }
}
