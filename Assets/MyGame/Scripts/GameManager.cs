using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FirstPuzzle ersteAufgabe;
    private bool einsteigen;
    public AudioSource hoHo;
  
    public CockieDetector zweiteAufgabe;
    public GameObject wandSchluss;
    public CockieSound cockieSound;
    public AudioSource mjam;

    private bool statusGiftDrop;
    private bool statusCockieTaken;
    

    private void Start()
    {
        
    }
    private void Update()
    {
        if (ersteAufgabe.giftDrop)
        {
            //Debug.Log("first puzzle Solved");
            hoHo.Play();
            ersteAufgabe.giftDrop = false;
            statusGiftDrop = true;
        }
        if (cockieSound.cockieAudio == true)
        {
            mjam.Play();
            cockieSound.cockieAudio = false;
            Debug.Log("hi");
        }
        
        if (zweiteAufgabe.cockieTaken)
        {
            //Debug.Log("second puzzle Solved");
            //zweiteAufgabe.cockieTaken = false;
            statusCockieTaken = true;
        }
        
        if (statusGiftDrop && statusCockieTaken)
        {
            wandSchluss.SetActive(false);

        }
        else {
            wandSchluss.SetActive(true);
        }
    }
        
}
