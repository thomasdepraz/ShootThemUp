using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusique : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource startAudioSource;
    public AudioClip musiqueDeFond;

    void Start()
    {
        startAudioSource = GetComponent<AudioSource>();

        startAudioSource.Play();

        
    }


}
