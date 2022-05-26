using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour
{
    public GameObject heartPrefab;
    float span = 1.5f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
        	this.delta = 0;
        	GameObject go = Instantiate(heartPrefab) as GameObject;
        	int px = Random.Range(-390,390);
        	go.transform.position = new Vector3(px, 778, 0);
            go.transform.SetParent(GameObject.FindGameObjectWithTag("bbbb").transform, false);
        }
    }
}
