using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCS : MonoBehaviour {

    UIManager UiScript;

    AudioSource audSource;

    private void Start()
    {
        UiScript = FindObjectOfType<UIManager>();
        audSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (UiScript.gameOver)
        {
            audSource.Stop();
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        Debug.Log("HIT");
        if (c.gameObject.tag == "Player")
        {
            Debug.Log("okay");
            UiScript.victory = true;
        }
    }
}
