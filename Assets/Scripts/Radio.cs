using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Radio : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioSource;
    void Start()
    
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;
    }
    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }
}
