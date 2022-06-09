using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dishCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
    	if(col.gameObject.tag == "bowl"){
    		Debug.Log("접촉");

            GameObject director = GameObject.Find("dishDirector");
            director.GetComponent<dishDirector>().IncreaseFood();
    	}
    }

    void OnCollisionExit(Collision coll)
    {
        if(coll.gameObject.tag == "bowl"){
            Debug.Log("추락");

            GameObject director = GameObject.Find("dishDirector");
            director.GetComponent<dishDirector>().DecreaseFood();
        }
    }
}
