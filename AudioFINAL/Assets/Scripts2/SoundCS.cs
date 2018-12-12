using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCS : MonoBehaviour {

    public static SoundCS me;

    public GameObject sndSource;

    public bool followPlayer;
    [Header("Player Sounds")]
    //public AudioClip[] ftspSlower;
    public AudioClip[] footsteps;
    public AudioClip[] ftspExtras;
    public AudioClip click;
    public AudioClip heartbeat;
    public AudioClip deepBreathing;


    public bool followDemon;
    [Header("Demon Sounds")]
    public AudioClip[] repeatSounds;
    public AudioClip dying;
    public AudioClip death;


    [Header("Ambience")]
    public AudioClip[] extras;
    public AudioClip[] trees;


    private void Awake()
    {
        me = this;
    }

    private void Start()
    {
        
    }

    public void PlaySound(AudioSource source, AudioClip clip, float vol, float pitch = 1f, float fade = 0f)
    {
        source.clip = clip;
        source.volume = vol;
        source.pitch = pitch;
        //add fade in later :/
        source.Play();
    }

    public void SpawnSound(AudioClip clip, Vector3 pos, float vol, int follow = 0, float pitch = 1f)
    {
        GameObject go = Instantiate(sndSource, pos, Quaternion.identity);
        AudioSource aud = go.GetComponent<AudioSource>();
        if (follow == 0) { 
            followPlayer = false;
            followDemon = false;
        }
        else if (follow == 1)
            followPlayer = true;
        else if (follow == 2)
            followDemon = false;


        aud.clip = clip;
        aud.volume = vol;
        aud.pitch = pitch;
        aud.Play();
    }


    
}
