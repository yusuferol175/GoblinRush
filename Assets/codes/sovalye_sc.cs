using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sovalye_sc : MonoBehaviour
{
    public static int can;
    public GameObject can_bar;

    public GameObject boom;
    public GameObject crack;

    private float arkaplan_x_pos = -45f;
    public GameObject arkaplan;

    public AudioClip dmg_ses;
    public AudioClip bip_ses;
    public AudioClip bomba_ses;
    public AudioClip kutu_ses;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="arkaplan")
        {
            Destroy(collision.gameObject.GetComponent<BoxCollider2D>());
            arkaplan_x_pos = arkaplan_x_pos + -60f;
            Instantiate(arkaplan, new Vector3(arkaplan_x_pos, -0.06f, -5f), arkaplan.transform.rotation);
        }

        if (collision.gameObject.tag=="kalp")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(bip_ses);
            Destroy(collision.gameObject,0.2f);
            can++;
            can_bar.GetComponent<bar_olay_sc>().kalp_durum();
        }
        if (collision.gameObject.tag == "coin")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(bip_ses);
            Destroy(collision.gameObject, 0.2f);
            scores.skor += 10;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (butonolay_oyun.kalkan_acik == true)
        {
            if (collision.gameObject.tag == "kutu")
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(kutu_ses);
                Destroy(Instantiate(crack, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, 0f), transform.rotation), 0.5f);
                Destroy(collision.gameObject);
                Debug.Log("stun");

            }
            if (collision.gameObject.tag=="bomba")
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(bomba_ses);
                Destroy(Instantiate(boom, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, 0f), transform.rotation), 0.5f);
                Destroy(collision.gameObject);
                Debug.Log("yooo");
            }
        }
        else if (butonolay_oyun.kalkan_acik == false)
        {
            if (collision.gameObject.tag == "bomba")
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(bomba_ses);
                gameObject.GetComponent<AudioSource>().PlayOneShot(dmg_ses);
                Destroy(Instantiate(boom, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, 0f), transform.rotation), 0.5f);
                Destroy(collision.gameObject);
                can--;
                if (can==0)
                {
                    SceneManager.LoadScene("olum");
                }
                can_bar.GetComponent<bar_olay_sc>().can_durum();
                Debug.Log("bum");
            }

            if (collision.gameObject.tag == "kutu")
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(kutu_ses);
                gameObject.GetComponent<AudioSource>().PlayOneShot(dmg_ses);
                Destroy(Instantiate(crack, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, 0f), transform.rotation), 0.5f);
                Destroy(collision.gameObject);
                can--;
                if (can == 0)
                {
                    SceneManager.LoadScene("olum");
                }
                can_bar.GetComponent<bar_olay_sc>().can_durum();
                Debug.Log("puf");

            }
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        can = 3;
        
        can_bar.GetComponent<bar_olay_sc>().kalp_durum();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
