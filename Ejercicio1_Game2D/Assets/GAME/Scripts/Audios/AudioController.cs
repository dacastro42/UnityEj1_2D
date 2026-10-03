using UnityEngine;
using System.Collections.Generic;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public List<AudioClip> listAudioClips;
    int posicion = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioClip()
    {
        audioSource.Stop();
        audioSource.clip = listAudioClips[posicion];
        audioSource.Play();

        //listAudioClips[Random.Range(0, listAudioClips.Count)]
       // audioSource.PlayOneShot(listAudioClips[posicion]);

        posicion++;
        if (posicion>=listAudioClips.Count)
        {
            posicion = 0;
        }
    }

}
