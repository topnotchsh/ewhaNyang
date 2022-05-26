using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GotoURL : MonoBehaviour
{
    public Text word;
    public void OpenURL(){
        Application.OpenURL($"https://search.naver.com/search.naver?where=nexearch&sm=tab_etc&mra=bk9D&qvt=0&query={word.text}");
    }
}
