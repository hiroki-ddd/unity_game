using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript1 : MonoBehaviour {

    int count;

    float speed = 8.0f;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 13.0f);
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position += this.transform.forward * speed * Time.deltaTime;
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("score", count);
            Destroy(this.gameObject);
        }
    }

}
