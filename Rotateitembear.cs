using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateitembear : MonoBehaviour
{
    public float speed = 100f;
    
    void Update()
    {
        transform.Rotate(0f , speed*Time.deltaTime , 0f);
    }
}
