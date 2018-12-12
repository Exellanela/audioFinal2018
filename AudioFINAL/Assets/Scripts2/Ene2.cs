using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene2 : MonoBehaviour {

    UIManager UIScript;
    Player2 PlayerScript;

    private float _timer;
    float distance;
    public float speed;
    public bool able2move;

    GameObject player;
    Vector3 playerPos;

    int hp = 100;

    MeshRenderer meshRenderer;
    public bool meshOn;
    public bool beingHit;

    IEnumerator Fadeout;
    AudioSource audSource;
    float volume;

    bool once = true;
    float screamTime = 0f;
    bool destroy;


    // Use this for initialization
    void Start()
    {
        //Debug.Log("HI");
        UIScript = FindObjectOfType<UIManager>();
        PlayerScript = FindObjectOfType<Player2>();
        player = GameObject.FindGameObjectWithTag("Player");

        meshRenderer = GetComponent<MeshRenderer>();
        _timer = Random.Range(2f, 5f);
        audSource = GetComponent<AudioSource>();
        audSource.clip = SoundCS.me.dying;
        volume = audSource.volume;
        Fadeout = FadeOut(audSource, 0.2f);
    }

    float deathTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if (destroy)
        {
            deathTime += Time.deltaTime;
            if (deathTime >= 2f)
            {
                Destroy(gameObject);
            }
            once = false;
            beingHit = false;
        }

        if (meshOn)
        { meshRenderer.enabled = true; }
        else { meshRenderer.enabled = false; }

        playerPos = player.transform.position;
        distance = Vector3.Distance(playerPos, transform.position);
        //Debug.Log(distance);

        if (distance <= 3f)
        {
            Sound.me.PlaySound(SoundCS.me.death, 0.1f);
            Destroy(gameObject);
            UIScript.gameOver = true;
        }
        /*
        else if (distance <= 5f)
        {
            //deep breathing (but not the players?)
            Sound.me.PlaySound(SoundCS.me.heartbeat, 1f);
            UIScript.DecreaseSanity(0.1f);
        }
        */
        else if (distance <= 7f)
        {
            //deep breathing (but not the players?)
            //Sound.me.PlaySound(SoundCS.me.heartbeat, 0.5f);
            //PlayerScript.SetVol(0.7f);
            UIScript.DecreaseSanity(0.08f);
        } else if (distance <= 10f)
        {
            //PlayerScript.SetVol(0.3f);
            UIScript.DecreaseSanity(0.02f);
        }
        /*
        else
        {
            PlayerScript.SetVol(0f);
        }
        */

        //rotate
        Vector3 targetDir = transform.position - playerPos;
        float step = 5 * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);



        //switch off with light
        if (able2move)
        {
            //move towards player
            float spd = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, playerPos, spd);

            //play random sound
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                PlayRandomGrowl();
                _timer = Random.Range(2f, 5f);
            }
        }

        //only happens once
        if (once && beingHit)
        {
            //Debug.Log("play");
            audSource.pitch = 1f;
            float randPitch = Random.Range(0.8f, 1.3f);
            audSource.volume = 1f;
            audSource.pitch = randPitch;
            audSource.Play();
            once = false;
        }


        if (beingHit)
        {
            //CHECK PLZ
            //PlayScreech().GetComponent<AudioSource>().Play();
            //DecreaseVol(audSource, 10f);
            able2move = false;
            meshOn = true;

            //if sound plays out
            
            screamTime += Time.deltaTime;
            
            if (screamTime >= audSource.clip.length - 1.7f)
            {
                destroy = true;
                //meshOn = false;
                beingHit = false;
            }

        } else
        {
            //Fadeout = FadeOut(PlayScreech().GetComponent<AudioSource>(), 1f);
            //Debug.Log("NO");
            //StartCoroutine(Fadeout);
            screamTime = 0f;
            DecreaseVol(audSource, 2f);
            able2move = true;
            meshOn = false;
        }
        beingHit = false;

        if (audSource.volume <= 0)
        {
            audSource.Stop();
        }


        //IF GAME OVER OR VIC
        if (UIScript.gameOver || UIScript.victory)
        {
            Destroy(gameObject);
        }
    }

    public void DecreaseVol(AudioSource source, float dec)
    {
        //float startVol = source.volume;
        
        source.volume -= dec * Time.deltaTime;
    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 dir = playerPos - transform.position;
        Ray ray = new Ray(transform.position, dir);
        RaycastHit rayHit = new RaycastHit();
        Debug.DrawRay(ray.origin, ray.direction * 400, Color.cyan);
        if (Physics.Raycast(ray, out rayHit))
        {
            if (rayHit.collider.tag == "Player")
            {
                //audSource.Play();
                beingHit = true;
            }
            else
            {
                once = true;
                //Debug.Log("NO");
                beingHit = false;
            }

            //Debug.Log(rayHit);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        once = true;
        beingHit = false;
    }


    public void PlayRandomGrowl()
    {
        /*
        int randInt = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.repeatSounds.Length - 1));
        float randPitch = Random.Range(0.7f, 1.2f);
        //SoundCS.me.PlaySound(audSource, SoundCS.me.footsteps[randInt], randPitch); //cutting off
        SoundCS.me.SpawnSound(SoundCS.me.repeatSounds[randInt], transform.position, 0.6f, 0, randPitch);
        */

        int randInt = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.repeatSounds.Length - 1));
        float randPitch = Random.Range(0.7f, 1.2f);
        //SoundCS.me.PlaySound(audSource, SoundCS.me.footsteps[randInt], randPitch); //cutting off
        SoundCS.me.SpawnSound(SoundCS.me.longThing, transform.position, 0.6f, 0, randPitch);
    }
    


    public IEnumerator FadeOut(AudioSource audioSource, float fadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            //audioSource.volume -= startVolume * Time.deltaTime / fadeTime;
            audioSource.volume -= 100*Time.deltaTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }
}
