using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    UIManager UIScript;

    //LAGS A LITTLE UNFORTUNATELY
    Vector3 inputVector;
    private Rigidbody _rb;
    Vector3 playerPos;

    public float speed;

    public GameObject flashlight;
    AudioSource hbSource; //THIS IS THE HEARTBEAT
    public float volume = 0f;
    public bool flashOn = true;

    Vector3 mousePos;

    float stepTimer = 0.2f;
    float audtimer;


    IEnumerator Fadeout;
    /*
    public AudioSource heartbeatAudiosource;
    bool heartActive;
    */

    float distanceFromClosest;



    void Start()
    {
        UIScript = FindObjectOfType<UIManager>();

        _rb = GetComponent<Rigidbody>();
        hbSource = GetComponent<AudioSource>();
        audtimer = Random.Range(5f, 20f);

        hbSource.clip = SoundCS.me.heartbeat;
        hbSource.volume = 0;
        //heartbeatAudiosource.clip = SoundCS.me.heartbeat;
    }

    void Update()
    {
        hbSource.volume = volume;

        playerPos = transform.position;
        transform.rotation = Quaternion.identity;
        _rb.angularVelocity = Vector3.zero;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        inputVector = transform.right * horizontal + transform.forward * vertical;

        if (inputVector.magnitude > 1)
        {
            inputVector = Vector3.Normalize(inputVector);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            //do the slow start thing he was saying if possible
            //HAH nope i wish
            //god i need help
            stepTimer -= Time.deltaTime;
            if (stepTimer <= 0)
            {
                int randInt = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.footsteps.Length - 1));
                int randInt2 = Mathf.RoundToInt(Random.Range(-10f, SoundCS.me.ftspExtras.Length - 1));
                float randPitch = Random.Range(0.7f, 1.2f);
                //SoundCS.me.PlaySound(audSource, SoundCS.me.footsteps[randInt], randPitch); //cutting off
                Sound.me.PlaySound(SoundCS.me.footsteps[randInt], 1f, randPitch);
                if (randInt2 >= 0)
                {
                    Sound.me.PlaySound(SoundCS.me.ftspExtras[randInt2], 0.2f, randPitch);
                }

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
            //SoundCS.me.SpawnSound(SoundCS.me.click, playerPos, 1f, 1);
            float randPitch = Random.Range(0.8f, 1.2f);
            Sound.me.PlaySound(SoundCS.me.click, 0.2f, randPitch);
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


        //AMBIENCE SOUNDS
        /*
         * 
         * //FUCK THIS
        audtimer -= Time.deltaTime;
        if (audtimer <= 0)
        {
            int randInt = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.extras.Length - 1));
            float randPitch = Random.Range(0.7f, 1.3f);
            
            Sound.me.PlaySound(SoundCS.me.extras[randInt], 0.5f, randPitch);

            Fadeout = FadeOut()

            audtimer = Random.Range(SoundCS.me.extras[randInt].length, SoundCS.me.extras[randInt].length + 30f);
        }
        */

        //SOUNDS I GUESS
        
        if (FindClosestEnemy() != null)
        {
            distanceFromClosest = Vector3.Distance(playerPos, FindClosestEnemy().transform.position);
            if (distanceFromClosest <= 5f)
            {
                volume += 0.08f;
            }
            else if (distanceFromClosest <= 9f)
            {
                volume += 0.02f;
            }
            else if (distanceFromClosest <= 15f)
            {
                volume += 0.002f;
            }
            else
            {
                volume -= 0.05f;
            }
        } 
        
    }


    public void FixedUpdate()
    {
        if (inputVector.magnitude > 0.01f)
        {
            _rb.velocity = inputVector * speed + Physics.gravity;
        }
    }


    public IEnumerator FadeOut(AudioSource audioSource, float fadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / fadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }

    public void SetVol(float vol)
    {
        volume = vol;
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
