using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volgMUis : MonoBehaviour
{
    [SerializeField] private GameObject imageje;
    [SerializeField] private Camera mainCamara;
    [SerializeField] private bool hover = false;
    [SerializeField] private bool inGebruik = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            imageje.SetActive(true);
        }

        if (hover == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            inGebruik = true;
        }
        if (!Input.GetKey(KeyCode.Mouse0))
        {
            inGebruik = false;
        }
        if (inGebruik == true)
        {
            Vector3 WorldView = mainCamara.ScreenToWorldPoint(Input.mousePosition);
            WorldView.z = 0f;
            transform.position = WorldView;
        }
        //transform.position += new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        // transform.position -= new Vector3(270, 104,0);
    }
    private void OnMouseOver()
    {
        hover = true;
    }
    private void OnMouseExit()
    {
        hover = false;
    }
}
