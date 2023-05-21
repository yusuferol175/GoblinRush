using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar_olay_sc : MonoBehaviour
{
    public Image kalp1;
    public Image kalp2;
    public Image kalp3;

    public Sprite kirmizi_kalp;
    public Sprite siyah_kalp;
    public void can_durum()
    {
        if (sovalye_sc.can == 0)
        {

            kalp1.gameObject.GetComponent<Image>().sprite = siyah_kalp;
        }
        if (sovalye_sc.can == 1)
        {

            kalp2.gameObject.GetComponent<Image>().sprite = siyah_kalp;
        }
        if (sovalye_sc.can == 2)
        {

            kalp3.gameObject.GetComponent<Image>().sprite = siyah_kalp;
        }

    }
    public void kalp_durum()
    {
        if (sovalye_sc.can == 1)
        {

            kalp1.gameObject.GetComponent<Image>().sprite = kirmizi_kalp;
        }
        if (sovalye_sc.can == 2)
        {

            kalp2.gameObject.GetComponent<Image>().sprite = kirmizi_kalp;
        }
        if (sovalye_sc.can == 3)
        {

            kalp3.gameObject.GetComponent<Image>().sprite = kirmizi_kalp;
        }
        if (sovalye_sc.can==4)
        {
            sovalye_sc.can = 3;
        }

    }
}
