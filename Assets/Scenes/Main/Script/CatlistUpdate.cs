using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatlistUpdate : MonoBehaviour
{
    public static CatlistUpdate instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }


    public int bg = 0;
    public int dgd = 0;
    public int ecc = 0;
    public int hmk = 0;
    public int lb = 0;
    public int podo = 0;
    public int posco = 0;



}
