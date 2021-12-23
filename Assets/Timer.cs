using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    GameObject admin;
    GameObject timer;
    void Start()
    {
        admin = GameObject.Find("dkanehdksTmfemtgksdlfma");
        timer = GameObject.Find("dkanehdksTmfemtgksdlfma2");
    }

    // Update is called once per frame
    void Update()
    {
        float Clear_Time = admin.GetComponent<ClearAdmin>().timer;
        
        if(admin.GetComponent<ClearAdmin>().Clear_Check == 1)
        {
            timer.GetComponent<Text>().text = "" + Clear_Time.ToString("F2");
        }
        
    }
}
