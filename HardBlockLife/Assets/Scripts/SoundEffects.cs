using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    AudioSource audioData;

    void Play()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }
}
