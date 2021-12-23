using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAdmin : MonoBehaviour
{
    public float timer;
    public float delay = 5;
    public float range = 0.1f;
    public int Clear_Check = 1;

    GameObject flash;
    
   
    void Start()
    {
        flash = GameObject.Find("dkanehdksTmfemtgksdlfma3");
    }

    
    void Update()
    {
        
        if (transform.rotation.z < 0.04 + range && transform.rotation.z > 0.04 - range)
        {
            timer += Time.deltaTime;
            //Debug.Log(timer);
            if (timer > delay)
            {
                
                Debug.Log("Clear!!");
                Clear_Check = 0;
                GetComponent<AudioSource>().Play();
                flash.GetComponent<Flash>().Fade();
                timer = 0;
                
            }
        }
        else
        {
            timer = 0;
        }
    }
}
