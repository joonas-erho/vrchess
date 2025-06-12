using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceAudio : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.pitch = Random.Range(0.5f, 1.5f);
        audioSource.Play();
    }
}
