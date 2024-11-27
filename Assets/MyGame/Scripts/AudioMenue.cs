using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AudioMenue : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private AudioSource myAudioSource;

    // 2 Variablen, um den Button und den Text zu finden 

    private GameObject playPauseButton; // Der Button 
    private TMP_Text playPauseButtonText; // das Textfeld 


    void Awake()
    {
        // get the Audio Source Component 
        myAudioSource = GetComponent<AudioSource>();

        // finde den Button des PlayPause-Button 
        playPauseButton = GameObject.Find("Play/PauseButton");

        // finde das Textfeld 
        playPauseButtonText = playPauseButton.GetComponentInChildren<TMP_Text>();
       
    }

    public void PlayAudio()
    {
        // AudioSource.play
        // Spiele die Audio-Source 
        FindAnyObjectByType<AudioManager>().Play("10-mySound-mhamzic");
    }

    public void PauseAudio()
    {
        FindAnyObjectByType<AudioManager>().Pause("10-mySound-mhamzic");
    }

    public void StopAudio() { 
    
        myAudioSource.Stop();
    }

    public void PlayPauseAudio()
    {
       if (myAudioSource.isPlaying)
        {
            myAudioSource.Pause();
            //playPauseButtonText.text = "Play";

        }
        else
        {
            myAudioSource.Play();
            //playPauseButtonText.text = "Pause";
        }
    }

    public void Update()
    {
        // Ändere den Button-Text
        if (myAudioSource.isPlaying)
        {
            playPauseButtonText.text = "Play";
        }
        else
        {
            playPauseButtonText.text = "Pause";
        }

        }

}
