using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCS : MonoBehaviour {
    //ON PLAYER


    //LAGS A LITTLE UNFORTUNATELY
    Vector3 inputVector;
    private Rigidbody rb;

    public float speed;

    public GameObject flashlight;
    public bool flashOn = true;

    float mouseSensitivity = 100f;
    Vector2 mousePos;



    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        //mousePos = Input.mousePosition;
    }

    public void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        inputVector = transform.right * horizontal + transform.forward * vertical;

        if (inputVector.magnitude > 1)
        {
            inputVector = Vector3.Normalize(inputVector);
        }


        //ROTATION (in ani it will only be the head and arm/flashlight)
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("YES");
            flashOn = !flashOn;
        }

        if (flashOn)
        {
            flashlight.SetActive(true);
        } else
        {
            flashlight.SetActive(false);
        }


        /*
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //by default the max raycast distance is infinity
        float maxRayDist = 10000f;
        */

        //Debug.DrawRay(myRay.origin, myRay.direction * maxRayDist, Color.red);

        
        //remembers where, when, distance, and angle the ray hit something
        //RaycastHit myRayHit = new RaycastHit();
    }
        

    public void FixedUpdate()
    {
        if (inputVector.magnitude > 0.01f)
        {
            rb.velocity = inputVector * speed + Physics.gravity;
        }
    }
}
