using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pacdot : MonoBehaviour
{
    
    public AudioSource Bgm;
    public AudioSource move;
   


    
       

  
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pac-Man")
        {

            Destroy(gameObject);
            Bgm.Play();
            move.Pause();
        

        }

    }

}
