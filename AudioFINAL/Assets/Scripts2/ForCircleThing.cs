using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCircleThing : MonoBehaviour {

    UIManager UiScript;

    public bool battery;
    public bool sanity;

    Image image;
    Color startCol;
    float timer = 1.5f;

    private void Start()
    {
        UiScript = FindObjectOfType<UIManager>();

        image = GetComponent<Image>();
        startCol = image.color;
    }

    private void Update()
    {
        if (battery)
        {
            if (UiScript.BatterySlider.value <= 20f)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    image.color = Color.red;
                    timer = 1.5f;
                }
                else
                {
                    image.color = startCol;
                }
            }
        }

        if (sanity)
        {
            if (UiScript.SanitySlider.value <= 30f)
            {
                image.color = Color.red;
            } else
            {
                image.color = startCol;
            }
        }
    }

}
