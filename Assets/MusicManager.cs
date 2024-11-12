using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public AudioClip track1, track2;
    AudioSource audioS;

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("keypressed down");

            if (audioS.clip == track1) //track 1 is the current clip
            {
                audioS.Stop();
                audioS.clip = track2;
                audioS.Play();
            }

            else
            {
                audioS.Stop();
                audioS.clip = track1;
                audioS.Play();
            }

            
        }
    }
}
