using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource.volume = 1;
        mixer.SetFloat("MyExposedParam", -80.0f);
        //audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioSource GetAudioSource()
    {
        return audioSource;
    }
}
