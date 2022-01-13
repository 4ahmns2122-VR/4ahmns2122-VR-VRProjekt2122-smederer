using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockieSound : MonoBehaviour
{
    public bool cockieAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "CustomHandLeft")
        {
            cockieAudio = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
