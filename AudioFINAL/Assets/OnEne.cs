using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEne : MonoBehaviour {

    private float _moveTimer;
    float distance;
    GameObject player;
    Vector3 playerPos;
    public AudioClip demonSound01;
    public AudioClip demonSound02;


	// Use this for initialization
	void Start () {
        //Debug.Log("HI");
        player = GameObject.FindGameObjectWithTag("Player");
        _moveTimer = Random.Range(2f, 8f);
	}
	
	// Update is called once per frame
	void Update () {
        playerPos = player.transform.position;

        _moveTimer -= Time.deltaTime;
        if (_moveTimer <= 0)
        {
            //play random sound
            float randNum = Random.Range(0, 2);
            if (randNum < 1)
            {
                Sound.me.PlaySound(demonSound01, 5);
            }
            else if (randNum < 2)
            {
                Sound.me.PlaySound(demonSound02, 5);
            }

            //move towards player
            Vector3.MoveTowards(transform.position, playerPos, 5);
            _moveTimer = Random.Range(2f, 8f);
        }
        
        //distance = Vector3.Distance(playerPos, transform.position);

        //rotate
        Vector3 targetDir = transform.position - playerPos;
        float step = 5 * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
