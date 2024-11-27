using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Instanzvariablen 

    [SerializeField] private Sound[] sounds;
    private AudioManager singleton;

    private void Awake()
    {
        // Stelle sicher, dass nur ein Element vom Typ AudioManager erzeugt werden kann
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            Destroy(gameObject);
            return;

        }

        DontDestroyOnLoad(gameObject);


        foreach (Sound s in sounds)
        {
            // Erzeuge zur Laufzeit ein AudioSource Objekt
            s.audioSource = gameObject.AddComponent<AudioSource>();
            // uebernehme Parameter vom Audio Element in AudioSource 
            s.audioSource.clip = s.clip;
            // Volume
            s.audioSource.volume = s.volume;
            // pitch
            s.audioSource.pitch = s.pitch;
        }
        /*
         for (int i = 0; i < sounds.length; i++){
                Sound s = sounds[i];
         }
        */
    }

    public void Play(string soundName)
    {
        FindSound(soundName).audioSource.Play();
    }

    public void Pause(string soundName)
    {
        FindSound(soundName).audioSource.Pause();
    }

    private Sound FindSound(string soundName)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == soundName)
            {
                return s;
            }
        }
        Debug.Log("Sound wurde nicht gefunden!");
        return null;
    }

        void Start()
        {

        }

        void Update()
        {

        }
    
}
