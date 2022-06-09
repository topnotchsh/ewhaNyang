using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearUpdate : MonoBehaviour
{
    public void clearBg()
    {
        CatlistUpdate.instance.bg = 1;
    }
    public void clearDgd()
    {
        CatlistUpdate.instance.dgd = 1;
    }
    public void clearEcc()
    {
        CatlistUpdate.instance.ecc = 1;
    }
    public void clearHmk()
    {
        CatlistUpdate.instance.hmk = 1;
    }
    public void clearLb()
    {
        CatlistUpdate.instance.lb = 1;
    }
    public void clearPodo()
    {
        CatlistUpdate.instance.podo = 1;
    }
    public void clearPosco()
    {
        CatlistUpdate.instance.posco = 1;
    }
}
