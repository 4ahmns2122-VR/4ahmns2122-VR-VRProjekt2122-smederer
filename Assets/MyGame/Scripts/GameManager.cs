using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FirstPuzzle ersteAufgabe;
    private bool einsteigen;
    public AudioSource hoHo;
    public SecondPuzzle zweiteAufgabe;


    private void Start()
    {
        
    }
    private void Update()
    {
        if (ersteAufgabe.giftDrop)
        {
            Debug.Log("first puzzle Solved");
            einsteigen = true;
            ersteAufgabe.giftDrop = false;
            hoHo.Play();
        }
    }
}
