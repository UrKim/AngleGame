using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Body : MonoBehaviour
{
    public float power = 2.46f;
    public float auto_power = 0.0738f;
    GameObject pivot;
   
    // Start is called before the first frame update
    void Start()
    {

        pivot = GameObject.Find("dkanehdksTmfemtgksdlfma");

    }

    // Update is called once per frame
    void Update()
    {

        
        int HeadPivot = 1;

        if (pivot.GetComponent<Key_Head>().HeadPivot_Check == 1)
        {
            HeadPivot = 1;
        }
        else if (pivot.GetComponent<Key_Head>().HeadPivot_Check == -1)
        {
            HeadPivot = -1;
        }
        else
        {
            HeadPivot = 0;
        }





        //Debug.Log("¸ö"+transform.rotation.z);

        if (pivot.GetComponent<ClearAdmin>().Clear_Check == 1)
        {
            if (transform.rotation.z > 0.07f * -1 && Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, power * -1);
            }
            if (transform.rotation.z < 0.067f && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(0, 0, power);
            }


            if (transform.rotation.z > 0.07f * -1 && transform.rotation.z < 0.067f)
            {
                transform.Rotate(0, 0, auto_power * HeadPivot);
            }
        }

            



    }
}
