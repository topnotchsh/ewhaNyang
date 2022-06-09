using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MissionClear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject check;

    void Start()
    {
        check.SetActive(false);
    }
    // Update is called once per frame
    public void Check()
    {
        check.SetActive(true);
    }

    public void Out()
    {
        check.SetActive(false);
    }
}
