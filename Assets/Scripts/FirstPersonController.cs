using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;




public class FirstPersonController : MonoBehaviour
{
    public float speed = 15;
    private float jumpPower = 4;
    Rigidbody rb;
    CapsuleCollider col;
    public Camera PlayerCamera;
    public GameObject crossHair;
    bool isActive;
    float HorizontalInput;
    float VerticalInput;


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        crossHair = GameObject.FindWithTag("CrossHair");
    }


    void Update()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetButtonDown("Sprint"))
        {
            speed = 30;
        }

        if (Input.GetButtonUp("Sprint"))
        {
            speed = 15;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            isActive = !isActive;
        }

        if (isActive)
        {
            crossHair.SetActive(true);
        }
        else
        {
            crossHair.SetActive(false);
        }
        
    }


    void FixedUpdate()
    {
        //Vector3 xMovement = transform.right * speed * HorizontalInput * Time.deltaTime;
        //Vector3 zMovement = transform.forward * speed * VerticalInput * Time.deltaTime;
        //rb.velocity = new Vector3(xMovement.magnitude, 0, zMovement.magnitude) * speed;

        Vector3 xMovement = PlayerCamera.transform.right * HorizontalInput;
        Vector3 zMovement = PlayerCamera.transform.forward * VerticalInput;
        rb.velocity = (xMovement + zMovement).normalized * speed;

        Vector3 forward = PlayerCamera.transform.forward;
        forward.y = 0;
        forward.Normalize();
        zMovement = forward * VerticalInput;

        if (isGrounded() && Input.GetButtonDown("Jump"))

        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
    

    private bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }
}