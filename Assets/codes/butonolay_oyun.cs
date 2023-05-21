using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class butonolay_oyun : MonoBehaviour
{
    public float MovementSpeed = 1;
    public GameObject sovalye;
    public GameObject kalkan;
    public GameObject kilic;

    bool hareket;

    public void menu()
    {
        
        SceneManager.LoadScene("menu");
    }
    public void move_start(bool sol_da_mi)
    {
        if (sol_da_mi)
        {
            if (sovalye.transform.localScale.x < 0)
            {
                sovalye.transform.localScale = new Vector3(sovalye.transform.localScale.x * -1, sovalye.transform.localScale.y, sovalye.transform.localScale.x);
                MovementSpeed *= -1;
            }

           
        }
        else
        {
            if (sovalye.transform.localScale.x > 0)
            {
                sovalye.transform.localScale = new Vector3(sovalye.transform.localScale.x * -1, sovalye.transform.localScale.y, sovalye.transform.localScale.x);
                MovementSpeed *= -1;
            }

           
        }

        hareket = true;
    }
    public void move_stop()
    {
        hareket = false;

    }
    private bool oncelik =false;
    public static bool kalkan_acik;
    public void kalkan_but_basla()
    {
        oncelik = true;
        kalkan_acik = true;
        kalkan.gameObject.SetActive(true);
        sovalye.GetComponent<Animator>().SetBool("kalkanmi", true);
    }
    public void kalkan_but_bit()
    {
        oncelik = false;
        kalkan_acik = false;
        kalkan.gameObject.SetActive(false);
        sovalye.GetComponent<Animator>().SetBool("kalkanmi", false);
    }
    private float kilic_hiz;
    private bool kilic_durum;
    private float kilic_pos_y;
    public AudioClip kilic_ses;
    public void kilic_but_basla()
    {
        oncelik = true;
        sovalye.GetComponent<AudioSource>().PlayOneShot(kilic_ses);
        sovalye.GetComponent<Animator>().SetBool("kilicmi", true);
        kilic.gameObject.SetActive(true);
        kilic_durum = true;
        
    }
    public void kilic_but_bitis()
    {
        oncelik = false;
        sovalye.GetComponent<Animator>().SetBool("kilicmi", false);
        kilic_durum = false;
        kilic.gameObject.SetActive(false);
    }
    void Start()
    {
        kilic_pos_y = -4f;
        kalkan.gameObject.SetActive(false);
        kilic.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kilic.transform.position.y > -1.3f)
        {
            kilic_hiz = 0f;
        }
        else if (kilic.transform.position.y < -1.3f)
        {
            kilic_hiz = 3.5f;
        }

        if (kilic_durum==true)
        {
            kilic.transform.position = new Vector3(kilic.transform.position.x, kilic.transform.position.y + kilic_hiz*Time.deltaTime, 0f);

        }
        else if (kilic_durum==false)
        {
            kilic.transform.position = new Vector3(kilic.transform.position.x, kilic_pos_y, 0f);
        }

        
        if (hareket)
        {
            if (sovalye.gameObject)
            {
                sovalye.transform.position += new Vector3(-MovementSpeed, 0, 0) * Time.deltaTime * 5;
                if (oncelik==false)
                {
                    sovalye.GetComponent<Animator>().SetBool("yurume", true);
                }
                if (oncelik == true)
                {
                    sovalye.GetComponent<Animator>().SetBool("yurume", false);
                }
                
                

            }

        }
        else
        {
           
                sovalye.GetComponent<Animator>().SetBool("yurume", false);
            
           
        }
    }
}
