using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPuzzle : MonoBehaviour
{
    public bool giftDrop = false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "DoorPuzzle1")
        {
            Debug.Log("present dropped");
            giftDrop = true;
        }
    }
    

}
