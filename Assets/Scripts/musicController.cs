using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicController : MonoBehaviour
{
    public GameObject cam; //variable c�mara
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = cam.GetComponent<AudioSource>(); //acceder a audioSource
    }
    public void MusicVallue(float vallue) //funci�n con un valor float
    {
        cam.GetComponent<AudioSource>().volume = vallue; //acceder al volumen del audioSource de la c�mara
    }
}
