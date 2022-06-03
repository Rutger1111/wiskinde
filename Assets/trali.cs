using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class trali : MonoBehaviour
{
    public GameObject hoek11;
    public GameObject hoek22;
    public bool onhoek;
    // Start is called before the first frame update
    void Start()
    {



    }



    // Update is called once per frame
    void Update()
    {
 
        if (transform.position.x == hoek22.transform.position.x && onhoek)
        {
            transform.position = new Vector3(transform.position.x, hoek22.transform.position.y, transform.position.z);
            onhoek = false;
        }
        else if (onhoek)
        {
            transform.position = new Vector3(hoek22.transform.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.x == hoek11.transform.position.x && !onhoek)
        {
            transform.position = new Vector3(transform.position.x, hoek11.transform.position.y, transform.position.z);
            onhoek = true;
        }
        else if (!onhoek)
        {
            transform.position = new Vector3(hoek11.transform.position.x, transform.position.y, transform.position.z);
        }




    }
}