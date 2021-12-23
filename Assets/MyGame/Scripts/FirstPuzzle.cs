using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPuzzle : MonoBehaviour
{
    public bool giftDrop = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "DoorPuzzle1")
        {
            Debug.Log("present dropped");
            giftDrop = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "DoorPuzzle1")
        {
            Debug.Log("present taken");
            giftDrop = false;
        }
    }
   

}
