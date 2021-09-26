using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject outside_wall;
    public GameObject outside_concer;
    public GameObject inside_wall;
    public GameObject inside_concer;
    public GameObject normal_pellet;
    public GameObject power_pellet;
    
    
    // Start is called before the first frame update
    void Start()
    {
         int[,] levelMap =
            {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,9},
        };

        print(levelMap[0, 13]);
        

        for ( int i = 0; i< 15; i++)
        {
           
            for(int j = 0; j< 14; j++)
            {
                
                //outside wall
                if(levelMap[i,j] == 2 )
                {
                   Instantiate(outside_wall, new Vector2(j, -i), Quaternion.identity);
                    print(levelMap[i, j]);
                   
                }
                //outside concer
                if (levelMap[i, j] == 1 && i==0)
                {
                   Instantiate(outside_concer, new Vector2(j, -i+1 ), Quaternion.identity);
                    
                }

                //normal pellet
                if (levelMap[i, j] == 5)
                {
               
                     Instantiate(normal_pellet, new Vector2(j+2, -i), Quaternion.identity);
                  
                }

                //power pellet
                if (levelMap[i, j] == 6)
                {
                    Instantiate(power_pellet, new Vector2(j+2, -i), Quaternion.identity);
                }
              
             
            }
          
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}