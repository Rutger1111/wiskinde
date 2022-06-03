using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lini : MonoBehaviour
{
    public LineRenderer liniieiiurwuiu;
    public GameObject gami1;
    public GameObject gami2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        liniieiiurwuiu.SetPosition(0, gami1.transform.position + (gami1.transform.position * 1000000 - gami2.transform.position * 1000000));
        liniieiiurwuiu.SetPosition(1, gami2.transform.position + (gami2.transform.position * 1000000 - gami1.transform.position * 1000000));
    }
}
