using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject message; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        message.GetComponent<SpriteRenderer>().enabled = false; 
    }
}
