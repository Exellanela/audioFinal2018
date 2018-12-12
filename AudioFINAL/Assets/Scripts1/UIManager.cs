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
    public static bool victory;

    public Canvas goCanvas;
    public Canvas vicCanvas;

    float timer = 5f;


    void Start()
    {
        //playerScript = FindObjectOfType<PlayerCS>();
        playerScript = FindObjectOfType<Player2>();
        goCanvas.enabled = false;
        vicCanvas.enabled = false;
        SanitySlider.value = 100;
        BatterySlider.value = 100;
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
            goCanvas.enabled = true;
            Time.timeScale = 0f;
        }

        if (playerScript.flashOn)
        {
            BatterySlider.value -= 0.03f;
        }
        if (BatterySlider.value <= 0)
        {
            playerScript.flashOn = false;
        }



        //SOUND SHIT plz help me

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
