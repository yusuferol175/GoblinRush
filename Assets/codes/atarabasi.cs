using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atarabasi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(-1*Time.deltaTime*4.5f, 0, 0);
    }
}
