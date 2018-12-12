using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSnd2 : MonoBehaviour {

    AudioSource source;
    AudioClip clip;
    float counter;

    GameObject player;
    bool followPlayer;
    bool followDemon;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        clip = source.clip;

        player = GameObject.FindGameObjectWithTag("Player");
        if (SoundCS.me.followPlayer)
            followPlayer = true;
        else
            followPlayer = false;

        if (SoundCS.me.followDemon)
            followDemon = true;
        else
            followDemon = false;
    }

    private void Update()
    {
        
        counter += Time.deltaTime;
        if (counter > clip.length + 1f)
        {
            Destroy(gameObject);
        }
        

        if (followPlayer)
        {
            transform.position = player.transform.position;
        }
        
        /*
        if (followDemon)
        {
            GameObject[] demons = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i=0; i<demons.Length; i++)
            {
                float closest = 1000f;
                float dist = Vector3.Distance(transform.position, demons[i].transform.position);

                if (dist < closest)
                {
                    closest = dist;
                    //unfinished realized i didn't need this shit
                }
            }


            //Vector3 dist = Vector3.Distance(this, )
            //GameObject nearestGO = 
            transform.position = player.transform.position;
        }
        */
    }
}
