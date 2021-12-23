using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    GameObject admin;

    void Start()
    {
        admin = GameObject.Find("dkanehdksTmfemtgksdlfma");
    }

    
    void Update()
    {
        if(admin.GetComponent<ClearAdmin>().Clear_Check == 0)
        {
            Destroy(gameObject);
        }
    }
}
