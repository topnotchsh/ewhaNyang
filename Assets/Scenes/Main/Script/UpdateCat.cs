using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCat : MonoBehaviour
{
    public GameObject bg;
    public GameObject dgd;
    public GameObject ecc;
    public GameObject hmk;
    public GameObject lb;
    public GameObject podo;
    public GameObject posco;

    void Update()
    {
        if (CatlistUpdate.instance.bg == 1)
        {
            bg.SetActive(true);
        }
        if (CatlistUpdate.instance.dgd == 1)
        {
            dgd.SetActive(true);
        }
        if (CatlistUpdate.instance.ecc == 1)
        {
            ecc.SetActive(true);
        }
        if (CatlistUpdate.instance.hmk == 1)
        {
            hmk.SetActive(true);
        }
        if (CatlistUpdate.instance.lb == 1)
        {
            lb.SetActive(true);
        }
        if (CatlistUpdate.instance.podo == 1)
        {
            podo.SetActive(true);
        }
        if (CatlistUpdate.instance.posco == 1)
        {
            posco.SetActive(true);
        }
    }
}
