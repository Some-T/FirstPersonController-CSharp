using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

// Below code is based off: https://youtu.be/Ohcx16kfuaA


public class FirstPersonController : MonoBehaviour
{
    [Range(0f, 100f )]
    public float mouseSensitivity = 70f;

    float horizontal;
    float vertical;
    float mouseX;
    float mouseY;

    Quaternion deltaRotation;
    Vector3 deltaPosition;

    Rigidbody rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInputs();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void FixedUpdate()
    {
        deltaRotation = Quaternion.Euler(Vector3.up * mouseX * mouseSensitivity * Time.fixedDeltaTime);
        rbody.MoveRotation(rbody.rotation * deltaRotation);
    }


    void GetInputs()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }


}
