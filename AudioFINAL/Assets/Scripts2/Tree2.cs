using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree2 : MonoBehaviour {

    //FOR SOUND
    UIManager UiScript;

    float oofTimer = 1f;

    private void Start()
    {
        UiScript = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        oofTimer -= Time.deltaTime;
    }

    private void OnCollisionEnter(Collision c)
    {
        //Debug.Log("Hit");
        if (c.gameObject.tag == "Player")
        {
            //Debug.Log("HI");
            int randInt = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.trees.Length - 1));
            float randPitch = Random.Range(0.7f, 1.2f);
            Sound.me.PlaySound(SoundCS.me.trees[randInt], 0.6f, randPitch);

            if (oofTimer <= 0f)
            {
                int randInt2 = Mathf.RoundToInt(Random.Range(0f, SoundCS.me.grunts.Length - 1));
                Sound.me.PlaySound(SoundCS.me.grunts[randInt2], 1f);
                oofTimer = Random.Range(30f, 200f);
            }
        }
    }
}
