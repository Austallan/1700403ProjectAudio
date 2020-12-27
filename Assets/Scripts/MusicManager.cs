using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public AudioSource door1;
    public AudioSource door2;
    public AudioSource door3;
    public AudioSource door4;
    public AudioSource victory;

    public AudioClip track1;
    public AudioClip track2;
    public AudioClip track3;
    public AudioClip track4;
    public AudioClip fanfare;

    private bool audioPlaying = false;
    private bool finale = false;
    private int trackNumber = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "door0")
		{
            trackNumber = 1;
            Debug.Log("track 1");

        }

        if (other.gameObject.tag == "door1")
        {
            trackNumber = 2;
            Debug.Log("track 2");
        }

        if (other.gameObject.tag == "door2")
        {
            trackNumber = 3;
            Debug.Log("track 3");
        }

        if (other.gameObject.tag == "door3")
        {
            trackNumber = 4;
            Debug.Log("track 4");
        }

        if (other.gameObject.tag == "doorReset")
        {
            trackNumber = 0;
            Debug.Log("track 0");
        }

        if (other.gameObject.tag == "door4")
        {
            trackNumber = 5;
            Debug.Log("track fanfare");
        }
    }

    void Update()
	{
        if (door1.isPlaying)
        {
            audioPlaying = true;
        }

        else if (door2.isPlaying)
        {
            audioPlaying = true;
        }

        else if (door3.isPlaying)
        {
            audioPlaying = true;
        }

        else if (door4.isPlaying)
        {
            audioPlaying = true;
        }

        else if (victory.isPlaying)
		{
            audioPlaying = true;
		}

        else
        {
            audioPlaying = false;
        }

        switch (trackNumber)
        {
            case 0:
                if (audioPlaying)
                {
                    door1.Stop();
                    door2.Stop();
                    door3.Stop();
                    door4.Stop();
                    audioPlaying = false;
                    Debug.Log("Audio Off");
                }
                break;

            case 1:
                if (!audioPlaying)
                {
                    door1.clip = track1;
                    door1.Play();
                    Debug.Log("Play Audio 1");
                    audioPlaying = true;
                }
                break;

            case 2:
                if (!audioPlaying)
                {
                    door2.clip = track2;
                    door2.Play();
                    Debug.Log("Play Audio 2");
                    audioPlaying = true;
                }
                break;

            case 3:
                if (!audioPlaying)
                {
                    door3.clip = track3;
                    door3.Play();
                    Debug.Log("Play Audio 3");
                    audioPlaying = true;
                }
                break;

            case 4:
                if (!audioPlaying)
                {
                    door4.clip = track4;
                    door4.Play();
                    Debug.Log("Play Audio 4");
                    audioPlaying = true;
                }
                break;

            case 5:

                door1.Stop();
                door2.Stop();
                door3.Stop();
                door4.Stop();
                audioPlaying = false;

                if (!audioPlaying && finale == false)
                {
                    victory.clip = fanfare;
                    victory.Play();
                    Debug.Log("Play Audio fanfare");
                    finale = true;
                }
                audioPlaying = true;
                
                break;

            default:
                Debug.Log("Audio Error");
                break;
        }

    }
}
