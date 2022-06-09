using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gonext : MonoBehaviour
{
    public GameObject howto;
    // Start is called before the first frame update
    void Start()
    {
        howto.SetActive(false);
    }

    // Update is called once per frame
    public void Clear()
    {
        howto.SetActive(true);
    }
}
