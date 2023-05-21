using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class olum_olaylari : MonoBehaviour
{
    public Text olumskor;
    private bool kaydedildi;

    public InputField isim_al;
    public void evedon()
    {
        if (kaydedildi == false)
        {
            PlayerPrefs.SetString("yeni_isim", "You");
        }
        if (PlayerPrefs.GetInt("yeni_skor") > PlayerPrefs.GetInt("skor"))
        {
            PlayerPrefs.SetString("isim", PlayerPrefs.GetString("yeni_isim"));
            PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("yeni_skor"));

        }
        SceneManager.LoadScene("menu");
    }
    public void oyunadon()
    {
        if (kaydedildi == false)
        {
            PlayerPrefs.SetString("yeni_isim", "You");
        }
        if (PlayerPrefs.GetInt("yeni_skor") > PlayerPrefs.GetInt("skor"))
        {
            PlayerPrefs.SetString("isim", PlayerPrefs.GetString("yeni_isim"));
            PlayerPrefs.SetInt("skor", PlayerPrefs.GetInt("yeni_skor"));

        }
        SceneManager.LoadScene("oyun");
        
    }

    public void isim_kaydet()
    {
        kaydedildi = true;
        if (isim_al.text=="")
        {

        }
        else
        {
            PlayerPrefs.SetString("yeni_isim", isim_al.text);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("olumsayisi", PlayerPrefs.GetInt("olumsayisi")+1);
        olumskor.text = ((int)scores.skor).ToString();
        PlayerPrefs.SetInt("yeni_skor", (int)scores.skor);

        kaydedildi = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
