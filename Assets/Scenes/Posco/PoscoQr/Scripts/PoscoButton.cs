using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoscoButton : MonoBehaviour
{
    public GameObject Bubble;
    public Button btnNext;
    void Start()
    {
        Bubble.SetActive(false);
        btnNext.onClick.AddListener(showBubble);
    }

    void showBubble(){
        Bubble.SetActive(true);
    }
}
