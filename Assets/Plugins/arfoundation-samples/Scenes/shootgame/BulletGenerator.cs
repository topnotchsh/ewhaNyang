using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    float span = 4f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
        	this.delta = 0;
        	GameObject go = Instantiate(bulletPrefab) as GameObject;
        	int px = Random.Range(-394,394);
        	go.transform.position = new Vector3(px, 978, 0);
            go.transform.SetParent(GameObject.FindGameObjectWithTag("aaaa").transform, false);
        }
    }
}
