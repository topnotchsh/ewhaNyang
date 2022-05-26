using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class dishDirector : MonoBehaviour
{
	public GameObject success;
    public GameObject destroy;
	public PlayableDirector playableDirector;
	GameObject foodGage;
    // Start is called before the first frame update
    void Start()
    {
        this.foodGage = GameObject.Find("foodGage");
    }

    public void IncreaseFood(){
    	this.foodGage.GetComponent<Image>().fillAmount += 0.5f;

    	if(this.foodGage.GetComponent<Image>().fillAmount == 1.0f){
    		destroy.SetActive(false);
            playableDirector.gameObject.SetActive(true);
            playableDirector.Play();
            success.SetActive(true);
    	}
    }

    public void DecreaseFood(){
        this.foodGage.GetComponent<Image>().fillAmount -= 0.5f;
    }
}
