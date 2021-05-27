using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    private AudioSource audioSrc;
    private AudioClip audioClip;
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioClip = GetComponent<AudioClip>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSrc.PlayOneShot(audioClip);
        }
    }


}
