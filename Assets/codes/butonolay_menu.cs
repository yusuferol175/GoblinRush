using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class butonolay_menu : MonoBehaviour
{
    public GameObject scoreboard;
    public GameObject scoreboard_but;
    public GameObject menubutton;


    public void basla()
    {
        PlayerPrefs.SetInt("bannerdurum", 1);
        PlayerPrefs.DeleteKey("yeni_isim");
        PlayerPrefs.DeleteKey("yeni_skor");
        SceneManager.LoadScene("oyun");
    }

    public void scoreboardac()
    {
        scoreboard.SetActive(true);
        menubutton.SetActive(true);
        scoreboard_but.GetComponent<AudioSource>().Play();
    }
    public void menubut()
    {
        scoreboard.SetActive(false);
        menubutton.SetActive(false);

    }

    public Text yuksek_sc;
    public Text yeni_sc;
    void Start()
    {

        
        scoreboard.SetActive(false);
        menubutton.SetActive(false);

        if (PlayerPrefs.GetInt("yeni_skor") > PlayerPrefs.GetInt("skor"))
        {
            PlayerPrefs.SetString("isim", PlayerPrefs.GetString("yeni_isim"));
            PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("yeni_skor"));

        }
        if (PlayerPrefs.GetString("isim") != "")
        {
            yuksek_sc.text = PlayerPrefs.GetString("isim") + "   " + PlayerPrefs.GetInt("skor") + "  " + "Score";
        }
        

        if (PlayerPrefs.GetString("yeni_isim") != "")
        {
            yeni_sc.text = PlayerPrefs.GetString("yeni_isim") + "   " + PlayerPrefs.GetInt("yeni_skor") + "  " + "Score";
        }
       
        


    }

    
    
}
