using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCS : MonoBehaviour {
    //ON PLAYER


    UIManager UIScript;

    //LAGS A LITTLE UNFORTUNATELY
    Vector3 inputVector;
    private Rigidbody rb;
    Vector3 playerPos;

    public float speed;

    public GameObject flashlight;
    public bool flashOn = true;

    float mouseSensitivity = 100f;
    Vector3 mousePos;

    public AudioClip grassWalk01;
    public AudioClip grassWalk02;
    public AudioClip click;
    int num = 0;
    float stepTimer = 0.2f;




    void Start()
    {
        UIScript = FindObjectOfType<UIManager>();

        rb = GetComponent<Rigidbody>();
        //mousePos = Input.mousePosition;
        playerPos = transform.position;
    }

    void Update()
    {
        transform.rotation = Quaternion.identity;
        rb.angularVelocity = Vector3.zero;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        inputVector = transform.right * horizontal + transform.forward * vertical;

        if (inputVector.magnitude > 1)
        {
            inputVector = Vector3.Normalize(inputVector);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            stepTimer -= Time.deltaTime;
            if (num >= 2) { num = 0; }
            if (stepTimer <= 0)
            {
                float randPitch = Random.Range(0.5f, 1.5f);
                if (num == 0) { Sound.me.PlaySound(grassWalk01, 1, randPitch); }
                if (num == 1) { Sound.me.PlaySound(grassWalk02, 1, randPitch); }
                num++;

                stepTimer = 0.2f;
            }
        }
        
        //ROTATION (in ani it will only be the head and arm/flashlight)
        mousePos = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePos);
        float maxRayDist = 10000f;
        Debug.DrawRay(mouseRay.origin, mouseRay.direction * maxRayDist, Color.red); //DEBUG!!!!!!!!!!!!!!!!!!!!!!!!
        RaycastHit mouseRayHit = new RaycastHit();

        if (Physics.Raycast(mouseRay, out mouseRayHit, maxRayDist))
        {
            //Debug.Log(flashlight.transform.position.y); 
            Vector3 newpoint = new Vector3(mouseRayHit.point.x, 0.0f, mouseRayHit.point.z);
            //flashlight.transform.LookAt(newpoint);
            
             flashlight.transform.LookAt(newpoint);
             var rotation = flashlight.transform.rotation.eulerAngles;
             rotation.x = -5.5f;
             flashlight.transform.rotation = Quaternion.Euler(rotation);
             
        }
        //clamp player pos
        playerPos.x = Mathf.Clamp(playerPos.x, -99f, 100f);
        playerPos.z = Mathf.Clamp(playerPos.z, -36f, 174f);
        



        if (Input.GetMouseButtonDown(0) && UIScript.BatterySlider.value > 0)
        {
            //Debug.Log("YES");
            Sound.me.PlaySound(click, 1);
            flashOn = !flashOn;
        }

        if (flashOn)
        {
            flashlight.SetActive(true);
            
        }
        else
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
