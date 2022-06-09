using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGM : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num == 0)
        {
            BGM.instance.mainBGM();
        }else if (num == 1)
        {
            BGM.instance.Shoot();
        }else if (num == 2)
        {
            BGM.instance.Lib();
        }else if (num == 3)
        {
            BGM.instance.Inven();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
