using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleController : MonoBehaviour
{
    public GameObject cube; //cube vallue


    private void Start()
    {
        cube.GetComponent<Transform>(); //acceder al transform del cubo
    }
    public void CubeScale(float size)
    {
        
    }
}
