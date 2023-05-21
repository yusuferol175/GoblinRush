using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atilan : MonoBehaviour
{

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="yer")
        {

            Destroy(gameObject);
        }
      
       
       
    }

    private float ivme=1f;
    private float hiz=4.5f;

    private Transform sovalye;

    
    // Update is called once per frame
    void Update()
    {

        if (gameObject.gameObject)
        {
            if (gameObject.transform.position.y > 2f)
            {
                ivme = 0f;
            }
            if (gameObject.transform.position.x>(olusan.sovalye_pos+olusan.atici_pos-1f)/2)
            {
               
                    ivme = -1f;
                
            }
            
            if (gameObject.transform.position.x>olusan.sovalye_pos)
            {
                hiz = 0f;
            }
            
            
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + hiz * Time.deltaTime, gameObject.transform.position.y+1.5f*ivme* Time.deltaTime, -5f);
        }


    }
}
