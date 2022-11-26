using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score ; 
    void Start()
    {
        score = 0;
    }


    void Update()
    {
        
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "item")
        {
            score ++;
        }
    }
}
