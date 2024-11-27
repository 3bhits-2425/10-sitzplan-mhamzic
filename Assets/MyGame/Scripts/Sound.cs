using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


// Klasse sound muss Serialisierbar sein 

[System.Serializable] // Serialisierbar heißt, dass es auch außerhalb der Laufzeit zugreifbar 

public class Sound { 

    // Instanzvariable für eine Audio-Datei 
    // Name der Audi-Datei
    public string name;
    // Der AudiCLip 
    public AudioClip clip;

    // Die Lautstärke 
    [Range(0f, 1f)] // Bereich gueltiger Zahlenwerte
    public float volume;

    // der Pitch
    [Range (0.1f, 3f)]
    public float pitch;

    [HideInInspector] public AudioSource audioSource;

    // Play Methode 
    /*
    void Play()
    {
        audioSource.Play();
    }
    */
}
