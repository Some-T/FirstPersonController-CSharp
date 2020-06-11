using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class FirstPersonController : MonoBehaviour
{
    public float speed = 5;
    public float jumpPower = 4;

    Rigidbody rb;
    CapsuleCollider col;


    private GameObject player;
    private float minClamp = -45;
    private float maxClamp = 45;
    [HideInInspector]
    public Vector2 rotation;
    private Vector2 currentLookRot;
    private Vector2 rotationV = new Vector2(0,0);
    public float lookSensitivity = 2;
    public float lookSmoothDamp = 0.1f;
    public Camera cam;
    public GameObject crossHair;
    bool isActive;
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;
    private float rotationX = 0F;
    private float rotationY = 0F;
    private Quaternion originalRotation;






    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        player = transform.gameObject;
        crossHair = GameObject.FindWithTag("CrossHair");


    }




    // Update is called once per frame
        void Update()
    {
        
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(Horizontal, 0, Vertical) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);



        if (isGrounded() && Input.GetButtonDown("Jump"))

        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetButtonDown("Sprint"))
        {
            speed = 15;
            //Debug.Log("Sprint Button Held Down");
        }

        if (Input.GetButtonUp("Sprint"))
        {
            speed = 5;
            //Debug.Log("Sprint Button Let Go");
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

        /*
        rotationX += Input.GetAxis("Mouse X") * sensitivityX;
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);
        transform.localRotation = originalRotation * xQuaternion * yQuaternion;
        */


        /*
        rotation.y += Input.GetAxis("Mouse Y") * lookSensitivity;
        rotation.y = Mathf.Clamp(rotation.y, minClamp, maxClamp);
        player.transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * lookSensitivity);
        currentLookRot.y = Mathf.SmoothDamp(currentLookRot.y, rotation.y, ref rotationV.y, lookSmoothDamp);
        cam.transform.localEulerAngles = new Vector3(-currentLookRot.y, 0, 0);
        */
    }

    private bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }




}