using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript1 : MonoBehaviour {

    float speed = 8.0f;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 13.0f);
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position += this.transform.forward * speed * Time.deltaTime;
	}
}
