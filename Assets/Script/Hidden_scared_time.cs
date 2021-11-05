using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hidden_scared_time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Scared").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
