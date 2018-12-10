using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEne : MonoBehaviour {

    UIManager UIScript;

    private float _timer;
    float distance;
    public float speed;
    GameObject player;
    Vector3 playerPos;

    int hp = 100;
    
    public AudioClip noise1;
    public AudioClip noise2;
    public AudioClip deathClip;
    public AudioClip screech;

    public static bool destroy;

    MeshRenderer meshRenderer;
    public bool meshOn;


	// Use this for initialization
	void Start () {
        //Debug.Log("HI");
        UIScript = FindObjectOfType<UIManager>();

        meshRenderer = GetComponent<MeshRenderer>();

        //play sound
        float randPitch = Random.Range(0.5f, 1.5f);
        Sound.me.PlaySound(noise1, 1, randPitch);

        

        player = GameObject.FindGameObjectWithTag("Player");
        _timer = Random.Range(2f, 5f);
	}
	
	// Update is called once per frame
	void Update () {

        if (meshOn)
        {
            meshRenderer.enabled = true;
        } else { meshRenderer.enabled = false; }

        playerPos = player.transform.position;
        distance = Vector3.Distance(playerPos, transform.position);
        if (distance <= 100f)
        {
            UIScript.DecreaseSanity(0.02f);
        }



        //rotate
        Vector3 targetDir = transform.position - playerPos;
        float step = 5 * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);

        
        //move towards player
        float spd = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, spd);
        
        if (hp <= 0)
        {
           Destroy(gameObject);
        }


        //play random sound
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            float randNum = Random.Range(0f, 2f);
            float randPitch = Random.Range(0.7f, 1.2f);
            if (randNum <= 1)
            {
                Sound.me.PlaySound(noise1, 0.3f, randPitch);
            }
            else if (randNum <= 2)
            {
                Sound.me.PlaySound(noise2, 0.3f, randPitch);
            }
            _timer = Random.Range(2f, 5f);
        }

    }
    /*
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Light")
        {
            Destroy(gameObject);
        }
    }
    */

    public void DecreaseLife()
    {
        hp--;
        Debug.Log(hp);
    }
}
