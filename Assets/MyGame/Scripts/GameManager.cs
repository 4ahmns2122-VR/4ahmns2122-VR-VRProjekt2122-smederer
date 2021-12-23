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


    private void Start()
    {
        
    }
    private void Update()
    {
        if (ersteAufgabe.giftDrop)
        {
            //Debug.Log("first puzzle Solved");
            //ersteAufgabe.giftDrop = false;
            hoHo.Play();
        }
        if (zweiteAufgabe.cockieTaken)
        {
            //Debug.Log("second puzzle Solved");
            //zweiteAufgabe.cockieTaken = false;
        }
        if (ersteAufgabe.giftDrop && zweiteAufgabe.cockieTaken)
        {
            wandSchluss.SetActive(false);

        }
        else {
            wandSchluss.SetActive(true);
        }
    }
        
}
