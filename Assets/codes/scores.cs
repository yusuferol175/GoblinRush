using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour
{
    public Text skortext;
    public static float skor;
    // Start is called before the first frame update
    void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        skor += 1 * Time.deltaTime;
        skortext.text = ((int)skor).ToString();
    }
}
