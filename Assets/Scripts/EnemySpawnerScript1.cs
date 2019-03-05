﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript1 : MonoBehaviour {

    public GameObject enemy;
    float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if(timer > 16)
        {
                Instantiate(enemy, this.transform.position + this.transform.right * Random.Range(-7.0f, 7.0f), this.transform.rotation);
                timer = 8;
        }
	}
}
