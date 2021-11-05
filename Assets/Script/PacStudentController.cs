using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PacStudentController : MonoBehaviour
{
    public Animator Controller;
    private bool Lastinput;
    private Vector2 movement = Vector2.zero;
    private float walkSpeed = 3.0f;
    public AudioSource Bgm;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        movePosition();
        moveAnimation();
     
    }

    public void moveAnimation()
    {
        if (Input.GetKey(KeyCode.W))
        {

            movement = Vector2.up;
            Controller.SetTrigger("Up");
            Bgm.Play();
            Lastinput = Input.GetKeyDown(KeyCode.W);

        }

        if (Input.GetKey(KeyCode.S))
        {
            movement = Vector2.down;
            Controller.SetTrigger("Down");
            Bgm.Play();
            Lastinput = Input.GetKeyDown(KeyCode.S);
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement = Vector2.left;
            Controller.SetTrigger("Left");
            Bgm.Play();
            Lastinput = Input.GetKeyDown(KeyCode.A);
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement = Vector2.right;
            Controller.SetTrigger("Right");
            Bgm.Play();
            Lastinput = Input.GetKeyDown(KeyCode.D);
        }
    }

        void movePosition()
        {
            transform.position += (Vector3)( movement * walkSpeed )* Time.deltaTime;

           
        }
    }

 


