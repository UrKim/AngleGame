using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Head : MonoBehaviour
{
    public float power = 6.0f;
    public float auto_power = 0.18f;
    public int HeadPivot_Check = 0;
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {





        //Debug.Log("¾ó±¼" + transform.rotation.z);

        if (GetComponent<ClearAdmin>().Clear_Check == 1)
        {
            if (transform.rotation.z > 0.15f * -1 && Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, power * -1);
            }
            if (transform.rotation.z < 0.19f && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(0, 0, power);
            }








            if (transform.rotation.z > 0.15f * -1 && transform.rotation.z < 0.04f)
            {
                transform.Rotate(0, 0, auto_power * -1);
                HeadPivot_Check = -1;

            }

            if (transform.rotation.z > 0.04f && transform.rotation.z < 0.19f)
            {
                transform.Rotate(0, 0, auto_power);
                HeadPivot_Check = 1;
            }

        }







    }
}
