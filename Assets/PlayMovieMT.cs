using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovieMT : MonoBehaviour
{
    public AudioClip movieAudioClip;
    public MovieTexture movieTexture;

    // Start is called before the first frame update
    void Start()
    {
        var audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = movieAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            var audioSource = GetComponent<AudioSource>();
            GetComponent<Renderer>().material.mainTexture = movieTexture;

            if (movieTexture.isPlaying)
            {
                movieTexture.Pause();
                audioSource.Pause();
            }
            else
            {
                movieTexture.Play();
                audioSource.Play();
            }
        }
    }
}
