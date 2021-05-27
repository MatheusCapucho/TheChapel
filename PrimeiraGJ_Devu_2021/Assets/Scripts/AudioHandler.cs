using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip audioClip;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioClip = GetComponent<AudioClip>();
    }

    public void PlayAudio()
    {
        audioSrc.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerM"))
        {
            audioSrc.PlayOneShot(audioClip);
        }
    }


}
