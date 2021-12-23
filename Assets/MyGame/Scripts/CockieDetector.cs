using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockieDetector : MonoBehaviour
{
    public bool cockieTaken;
  
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cockie")
        {
            cockieTaken = true;
            
        }
    }
}
