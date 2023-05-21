using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilic_olay_sc : MonoBehaviour
{
    public GameObject kalp;
    public GameObject coin;

    private int rast_nesne_;

    private GameObject olusan;

    private bool olusma_durum;
    System.Random random = new System.Random();

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="kutu")
        {
            
            
            Debug.Log("kutu patla");
            rast_nesne_ = random.Next(0, 5);
            if (rast_nesne_ == 0)
            {
                olusan = kalp;
                olusma_durum = true;
            }
            else if (rast_nesne_ == 1||rast_nesne_==2)
            {
                olusan = coin;
                olusma_durum = true;
            }
            else if (rast_nesne_ == 3 || rast_nesne_ == 4)
            {
                olusma_durum = false;

            }
            if (olusma_durum == true)
            {
                Instantiate(olusan, new Vector3(collision.gameObject.transform.position.x - 1f, collision.gameObject.transform.position.y, 0f), kalp.transform.rotation);
            }
           
            Destroy(collision.gameObject);
        }

    }

  
}
