﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.gameObject.tag == "Player"){
            

            Destroy(this.gameObject);

            GameObject director1 = GameObject.Find("HeartGameDirector");
            director1.GetComponent<HeartGameDirector>().DecreaseHeart();
    	}
    }
}
