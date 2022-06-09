using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionClear : MonoBehaviour
{
    public GameObject curve1;
    public GameObject curve2;
    public GameObject curve3;

    public GameObject text1;
    public GameObject text2;
    public GameObject button;
    public GameObject image;

    // Update is called once per frame
    void Update()
    {
        if ((curve1.GetComponent<MeshRenderer>().material.color == Color.green) ||
            (curve2.GetComponent<MeshRenderer>().material.color == Color.green) ||
            (curve3.GetComponent<MeshRenderer>().material.color == Color.green))

            image.SetActive(false);

        if ((curve1.GetComponent<MeshRenderer>().material.color == Color.green) && 
            (curve2.GetComponent<MeshRenderer>().material.color == Color.green) && 
            (curve3.GetComponent<MeshRenderer>().material.color == Color.green))
        {
            text1.SetActive(false);
            text2.SetActive(true);
            button.SetActive(true);
        }
        
    }
}
