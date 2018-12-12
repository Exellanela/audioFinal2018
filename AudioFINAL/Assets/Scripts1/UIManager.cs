using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    //PlayerCS playerScript;
    Player2 playerScript;

    public Slider SanitySlider;
    public Slider BatterySlider;

    public bool gameOver;
    public bool victory;

    public Canvas goCanvas;
    public Canvas vicCanvas;

    float timer = 1.5f;


    AudioSource ambienceSource;


    void Start()
    {
        //playerScript = FindObjectOfType<PlayerCS>();
        playerScript = FindObjectOfType<Player2>();
        goCanvas.enabled = false;
        vicCanvas.enabled = false;
        SanitySlider.value = 100;
        BatterySlider.value = 100;

        ambienceSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (SanitySlider.value <= 0)
        {
            gameOver = true;
        }
        /*
        else if (SanitySlider.value <= 20)
        {
            Sound.me.PlaySound(SoundCS.me.heartbeat, 0.3f);
        }
        */

        if (victory)
        {
            vicCanvas.enabled = true;
            Time.timeScale = 0f;
        }
        if (gameOver)
        {
            ambienceSource.Stop();
            goCanvas.enabled = true;
            Time.timeScale = 0f;
        }

        if (playerScript.flashOn)
        {
            BatterySlider.value -= 0.03f;
        }
        if (BatterySlider.value <= 0f)
        {
            playerScript.flashOn = false;
        }



        //SOUND SHIT plz help me
        if (BatterySlider.value <= 20f)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                Sound.me.PlaySound(SoundCS.me.alert, 0.6f);
                timer = 1.5f;
            }
        }
    }

    public void DecreaseSanity(float amt)
    {
        /*
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SanitySlider.value -= amt;
            timer = 5f;
        }
        */
        SanitySlider.value -= amt;
    }
}
