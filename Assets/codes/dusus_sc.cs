using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusus_sc : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y<-3f)
        {
            Destroy(gameObject.GetComponent<Rigidbody2D>());
        }
    }
}
