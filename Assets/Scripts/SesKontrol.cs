using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField] AudioClip asteroidPatlama;

    [SerializeField] AudioClip gemiPatlama;
    
    [SerializeField] AudioClip ates;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AsteroidPatlama()
    {
        audioSource.PlayOneShot(asteroidPatlama);
    }

    public void GemiPatlama()
    {
        audioSource.PlayOneShot(gemiPatlama);
    }

    public void Ates()
    {
        audioSource.PlayOneShot(ates,0.4f);
    }
}
