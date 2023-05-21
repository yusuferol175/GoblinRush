using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gectin_sc : MonoBehaviour
{
    private bool iceride;
    public GameObject saydam_red;

    private float sayac;

     void Start()
    {
        saydam_red.SetActive(false); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="sovalye")
        {
            iceride = true;
            saydam_red.SetActive(true);
        }
       
    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sovalye")
        {
            sayac= 0f;
            iceride = false;
            saydam_red.SetActive(false);
        }
        
    }

    void Update()
    {
        if (iceride==true)
        {
            sayac += Time.deltaTime * 1;
            if (sayac > 10f)
            {
                SceneManager.LoadScene("olum");
            }
        }
        
    }
}
