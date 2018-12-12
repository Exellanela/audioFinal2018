using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree2 : MonoBehaviour {

    //FOR SOUND
    

    private void OnCollisionEnter(Collision c)
    {
        //Debug.Log("Hit");
        if (c.gameObject.tag == "Player")
        {
            //Debug.Log("HI");
            int randInt = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.trees.Length - 1));
            float randPitch = Random.Range(0.7f, 1.2f);
            Sound.me.PlaySound(SoundCS.me.trees[randInt], 0.6f, randPitch);
        }
    }
}
