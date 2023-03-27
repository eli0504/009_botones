using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //FUNCIONES DE LOS BOTONES

    public Button playButton, pauseButton; //variables


    public void PlayButtonFunction() //pulso boton play y se desactiva
    {
        playButton.interactable = false;
    }

    public void PauseButtonFunction() //pulso pause y se activa play
    {
        playButton.interactable = true;
        pauseButton.interactable = false;
    }
}
