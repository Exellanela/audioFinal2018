using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCS : MonoBehaviour {

    public static SoundCS me;

    public GameObject sndSource;

    [Header("Player Sounds")]
    public AudioClip[] footsteps;
    public AudioClip click;
    public AudioClip heartbeat;
    //public AudioClip deepBreathing;

    [Header("Demon Sounds")]
    public AudioClip[] repeatSounds;
    public AudioClip dying;
    public AudioClip death;

    [Header("Ambience")]
    public AudioClip[] extras;


    private void Awake()
    {
        me = this;
    }

    private void Start()
    {
        
    }

    public void PlaySound(AudioClip clip, float vol, float pitch = 1f, float fade = 1f)
    {
        //help
    }

    public void SpawnSound(AudioClip clip, Vector3 pos, float vol, float pitch = 1f)
    {
        GameObject go = Instantiate(sndSource, pos, Quaternion.identity);
        AudioSource aud = go.GetComponent<AudioSource>();
        aud.clip = clip;
        aud.volume = vol;
        aud.pitch = pitch;
        aud.Play();
    }
}
