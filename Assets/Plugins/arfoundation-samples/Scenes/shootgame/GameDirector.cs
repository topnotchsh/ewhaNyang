using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
	public GameObject GameOverText;
    public GameObject BulletGenerator;
    public GameObject HeartGenerator;

    GameObject hpGage;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHp(){

    	this.hpGage.GetComponent<Image>().fillAmount += 0.2f;
        
        if(this.hpGage.GetComponent<Image>().fillAmount == 1.0f){
            GameOverText.SetActive(true);
            BulletGenerator.SetActive(false);
            HeartGenerator.SetActive(false);

        }
    }
}
