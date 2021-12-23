using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour
{

    public Image Panal;
    float time = 0f;
    float F_time = 0.25f;
    public void Fade()
    {
        StartCoroutine(FadeFlow());
    }
    IEnumerator FadeFlow()
    {
        Panal.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panal.color;
        while(alpha.a <1f )
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panal.color = alpha;
            yield return null;
        }
        time = 0f;        
        yield return new WaitForSeconds(1f);
        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panal.color = alpha;
            yield return null;
        }

        Application.Quit();
        Panal.gameObject.SetActive(false);
        yield return null;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
