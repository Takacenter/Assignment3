using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManMovement : MonoBehaviour
{
    public GameObject pacman;
    public AudioSource BGM;
    private pmTweener pmtweener;
    private GameObject np1;
    private GameObject np2;
    private GameObject np3;
    private GameObject np4;
    public Animator Controller;
    private float px;
    private float py;
    

    
    // Start is called before the first frame update
    void Start()
    {
        pmtweener = GetComponent<pmTweener>();

        //np1 is the bottom-left corener pellet, 
        //np2 is the top-left corener pellet, 
        //np3 is the top-right corener pellet.
        //np4 is the bottom-right corener pellet.


        np1 = GameObject.FindWithTag("Normal pellet1");
        np2 = GameObject.FindWithTag("Normal pellet2");
        np3 = GameObject.FindWithTag("Normal pellet3");
        np4 = GameObject.FindWithTag("Normal pellet4");

        // the music of movement
        
     

    }

    // Update is called once per frame
    void Update()
    {

        px = pacman.transform.position.x;
        py = pacman.transform.position.y;

        Left_and_right_dir();
        
        pmAnim();

        

    }
    // the left and right direction of pac man
    void Left_and_right_dir()
    {
        if (px > np1.transform.position.x && py == np4.transform.position.y)
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                pmtweener.AddPacMan(pacman.transform, pacman.transform.position, np1.transform.position, 4f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                pmtweener.AddPacMan(pacman.transform, pacman.transform.position, np4.transform.position, 4f);
            }
        }

       /*** if (px < np3.transform.position.x && py == np2.transform.position.y && Input.GetKeyDown(KeyCode.D))
        {

            pmtweener.AddPacMan(pacman.transform, pacman.transform.position, np3.transform.position, 4f);
           

        }***/
      
    }
    // the up and down direction of pac man
    void Up_and_Down_dir()
    {
        if (py < np2.transform.position.y && px == np1.transform.position.x && Input.GetKeyDown(KeyCode.W))
        {

            pmtweener.AddPacMan(pacman.transform, pacman.transform.position, np2.transform.position, 4f);

          

        }


        if (py> np4.transform.position.y && px == np3.transform.position.x && Input.GetKeyDown(KeyCode.S))
        {

            pmtweener.AddPacMan(pacman.transform, pacman.transform.position, np4.transform.position,4f);

           


        }
      
    }

    // animation of pacman
    void pmAnim()
    {
        if (pacman.transform.position.x > np1.transform.position.x && pacman.transform.position.y == np4.transform.position.y)
        {


            Controller.SetTrigger("Left");
        }



        if (pacman.transform.position.y >= np1.transform.position.y && pacman.transform.position.x == np1.transform.position.x && pacman.transform.position.y <= np2.transform.position.y)
        {


            Controller.SetTrigger("Up");


        }

        if (pacman.transform.position.x <= np3.transform.position.x && pacman.transform.position.x >= np2.transform.position.x && pacman.transform.position.y == np2.transform.position.y)
        {
            Controller.SetTrigger("Right");
        }

        if (pacman.transform.position.y >= np4.transform.position.y && pacman.transform.position.x == np3.transform.position.x && pacman.transform.position.y <= np3.transform.position.y)
        {
            Controller.SetTrigger("Down");
        }
    }
}
