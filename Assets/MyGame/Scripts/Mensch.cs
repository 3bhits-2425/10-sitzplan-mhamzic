using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using UnityEngine;

public class Mensch : MonoBehaviour
{
    // Start is called before the first frame update
    // Instanzvariablen 
    public string personName;
    public string rolleInKlasse;
    public Color augenfarbe;

    [SerializeField] private AudioSource myAudioSource;
    void Start()
    {
            Debug.Log("Mein Name: " + personName);
            Debug.Log("Meine Rolle in der Klasse: " + rolleInKlasse);
            Debug.Log("Meine Augenfarbe: " + augenfarbe);

            myAudioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        //Sobald die Leertaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste wurde gedrückt!");
            // Starte die Audio-Wiedergabe
            myAudioSource.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Leertaste wurde losgelassen!");
            myAudioSource.Pause();
        }
    }
}
