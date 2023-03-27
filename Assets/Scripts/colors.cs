using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colors : MonoBehaviour
{
    public GameObject ball; //ball variable
    public Button pink, purple, blue, yellow; //colors variables

    //materials
    private Material _material;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
    }
    public void HasBeenClickTheColour()
    {
        if (Input.GetButtonDown("blue"))
        {
            _material.color = Color.blue;
        }
        else if (Input.GetButtonDown("purple"))
        {
            
        }
    }
}
