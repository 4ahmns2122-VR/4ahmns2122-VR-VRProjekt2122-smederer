using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPuzzle : MonoBehaviour
{
    //public bool lichtAn;
    //public BoxCollider pass;
    float startTime = 5f;
    public float timer;
    public int seconds;
    public BoxCollider colide;
    public bool lichtAN = true;
    public GameObject licht;
    //auf objekt01 ohne Mesh mit collider der (de)aktiviert wird 
    //method timer runterzählen
    //methode die colliuder von objekt01 (de)aktiviert (trigger) - Später abhänging von timer 



    void Start()
    {
        StartCoroutine(Timer());
        colide = GetComponent<BoxCollider>();
        licht.SetActive(true);
        
    }

    private IEnumerator Timer()
    {
        timer = startTime;
        do
        {
            timer -= Time.deltaTime;
            FormalText();
            yield return 0;
        }
        while (timer > 0);

        if(timer <= 0)
        {
            timer = startTime;
            StartCoroutine(Timer());

            if (Random.Range(0, 2) == 0)
            {
                lichtAN = false;
                colide.enabled = false;
                licht.SetActive(false);

            }
            else
            {
                lichtAN = true;
                colide.enabled = true;
                licht.SetActive(true);
            }
        }
       
       
    }
    private void FormalText()
    {
        seconds = (int)(timer % 60);
        if(seconds > 0)
        {
            //Debug.Log(seconds + "seconds");
        }
    }

    void Update()
    {
        
        //Debug.Log(randomVal);
    }
}
