using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerAnimationScript : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    public void playSound()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
