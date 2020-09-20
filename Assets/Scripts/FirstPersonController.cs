using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;




public class FirstPersonController : MonoBehaviour
{
    private float speed = 5;
    private float jumpPower = 5;
    Rigidbody rb;
    CapsuleCollider col;
    public Camera PlayerCamera;
    public GameObject crossHair;
    bool isActive;
    float HorizontalInput;
    float VerticalInput;
    public GameObject mainPlayer;
    float mainPlayerHeight;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        crossHair = GameObject.FindWithTag("CrossHair");
        mainPlayer = GameObject.FindWithTag("Player");
        mainPlayerHeight = col.height;
    }


    void Update()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
        Vector3 xMovement = PlayerCamera.transform.right * HorizontalInput;
        Vector3 zMovement = PlayerCamera.transform.forward * VerticalInput;
        Vector3 velocity = (xMovement + zMovement).normalized * speed;
        Vector3 forward = PlayerCamera.transform.forward;
        
        velocity.y = rb.velocity.y;
        rb.velocity = velocity;
        forward.y = 0;
        forward.Normalize();
        zMovement = forward * VerticalInput;

        if (isGrounded() && Input.GetButtonDown("Jump"))

        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }


        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetButtonDown("Sprint"))
        {
            speed = 15;
            Debug.Log("Speed is now: " + speed);
        }

        if (Input.GetButtonUp("Sprint"))
        {
            speed = 5;
            Debug.Log("Speed is now: " + speed);
        }

        int caseSwitch = 1;
        bool keyPress = false;


        switch (caseSwitch)
        {
            case 1:
                if (Input.GetKeyDown(KeyCode.LeftControl))
                {
                    mainPlayer.transform.localScale = new Vector3(1.0f, 0.5f, 1.0f);
                    jumpPower = 0;
                    Debug.Log("Case 1");
                    keyPress = true;
                }
                else if (keyPress == true && Input.GetKeyDown(KeyCode.LeftControl))
                {
                    goto case 2;
                    }
                    break;
            case 2:
                
                    mainPlayer.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                    jumpPower = 5;
                    Debug.Log("Case 2");
                    
                /*if (!Physics.Raycast(transform.position, Vector3.up, (mainPlayerHeight / 2) + 0.1f)) 
                {
                goto case 3;
                }*/
                break;
            case 3:
                {
                    mainPlayer.transform.localScale = new Vector3(1.0f, 0.5f, 1.0f);
                    jumpPower = 5;
                    Debug.Log("Case 2");
                }
                break;

            default:
                Debug.Log("Default case");
                break;
        }

        /*
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
        mainPlayer.transform.localScale = new Vector3(1.0f, 0.5f, 1.0f);
        jumpPower = 0;
        Debug.Log("Left control held down");
        }

        if (!Input.GetKey(KeyCode.LeftControl) && !Physics.Raycast(transform.position, Vector3.up, (mainPlayerHeight / 2)+0.1f))
        {
        mainPlayer.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        jumpPower = 5;
        Debug.Log("Left control no longer held down");
        }
*/

        /*
        bool isKeyUp = Input.GetKeyUp(KeyCode.LeftControl);
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
        isKeyUp = false;
        mainPlayer.transform.localScale = new Vector3(1.0f, 0.5f, 1.0f);
        jumpPower = 0;
        Debug.Log("Left control held down");
        }

        if (isKeyUp && !Physics.Raycast(transform.position, Vector3.up, (mainPlayerHeight / 2)+0.1f))
        {
        mainPlayer.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        jumpPower = 5;
        Debug.Log("Left control no longer held down");
        }
        */


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

    private bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }
}