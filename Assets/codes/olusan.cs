using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olusan : MonoBehaviour
{
    private float sayac;
    public GameObject bomba;
    public GameObject kutu;

        
    public GameObject atilan_pos;

    public GameObject at_araba_pos;
    public GameObject sovalye;
    public GameObject goblin;

    public bool olusma = false;

    public void bomba_at()
    {
        if (olusma == false)
        {
            Instantiate(bomba, new Vector3(atilan_pos.transform.position.x, atilan_pos.transform.position.y, 0f), transform.rotation);

            olusma = true;
        }

    }
    public void kutu_at()
    {
        if (olusma == false)
        {

            Instantiate(kutu, new Vector3(atilan_pos.transform.position.x, atilan_pos.transform.position.y, 0f), transform.rotation);


            olusma = true;
        }

    }
    void Start()
    {
        
    }
    public static float atici_pos;
    public static float sovalye_pos;

    private int rast_nesne;
    // Update is called once per frame
    System.Random random = new System.Random();
    void Update()
    {
        sayac += Time.deltaTime * 1;
        if (sayac > 3)
        {
            goblin.GetComponent<Animator>().SetBool("attimi", true);
            Invoke("atildi", 1f);
            
            sovalye_pos =  sovalye.transform.position.x-6f;
            atici_pos=  at_araba_pos.transform.position.x-5.5f;
            olusma = false;
            rast_nesne = random.Next(0, 2);
            if (rast_nesne==0)
            {
                bomba_at();
            }
            else if (rast_nesne==1)
            {
                kutu_at();
            }
             
            sayac = 0;
        }

       
    }
    public void atildi()
    {
        goblin.GetComponent<Animator>().SetBool("attimi", false);
    }
}
