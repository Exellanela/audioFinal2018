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
    Vector3 mousePos;



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
        mousePos = Input.mousePosition;
        /*
        Vector3 targetDir = transform.position - mousePos;
        float step = 2 * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
        */

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePos);
        float maxRayDist = 10000f;
        Debug.DrawRay(mouseRay.origin, mouseRay.direction * maxRayDist, Color.red); //DEBUG!!!!!!!!!!!!!!!!!!!!!!!!
        RaycastHit mouseRayHit = new RaycastHit();

        if (Physics.Raycast(mouseRay, out mouseRayHit, maxRayDist))
        {
            Vector3 newpoint = new Vector3(mouseRayHit.point.x, flashlight.transform.position.y, mouseRayHit.point.z);
            //Debug.Log(newpoint);
            flashlight.transform.LookAt(newpoint);
        }



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
    }
        

    public void FixedUpdate()
    {
        if (inputVector.magnitude > 0.01f)
        {
            rb.velocity = inputVector * speed + Physics.gravity;
        }
    }
}
