using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{   
    public GameObject pipePrefab; 
    //Instantiate

    private float countdown; 
    public float timeDuration;
    public bool enableGenratePipe; //cho phep sinh ra ong

    private void Awake()
    {
        countdown = 1f; 
        enableGenratePipe = false;  
    }
    void Update()
    {
        if(enableGenratePipe == true)
        {
             countdown -= Time.deltaTime; //moi frame countdown -= 1/FPS
        if(countdown <=0)
        {
            //sinh ra ong
             Instantiate(pipePrefab, new Vector3(8 , Random.Range(-1.2f, 2.1f), 0), Quaternion.identity); 
            countdown = timeDuration; 
        }
        }
       
    }
}
