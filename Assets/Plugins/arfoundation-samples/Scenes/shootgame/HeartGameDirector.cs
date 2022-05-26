using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartGameDirector : MonoBehaviour
{
	public GameObject GameOverText;
    public GameObject BulletGenerator;
    public GameObject HeartGenerator;

    GameObject lifeGage;
    // Start is called before the first frame update
    void Start()
    {
        this.lifeGage = GameObject.Find("lifeGage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHeart(){

    	this.lifeGage.GetComponent<Image>().fillAmount -= 0.333f;
        
        if(this.lifeGage.GetComponent<Image>().fillAmount == 0.0f){
            GameOverText.SetActive(true);
            BulletGenerator.SetActive(false);
            HeartGenerator.SetActive(false);
        }
    }
}
