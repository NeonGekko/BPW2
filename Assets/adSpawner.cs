﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adSpawner : MonoBehaviour {

	public GameObject adSpawnpoint1;
	public GameObject adSpawnpoint2;
	public GameObject adspawnPoint3;
	public GameObject adSpawnpoint4;

	public float minX = 0;
	public float maxX = 10;
	public float minY = 0;
	public float maxY = 10;
	public float minZ = -3;
	public float maxZ = 0;

	public Sprite adProducts;

 	void Start(){
		float x = Random.Range(minX, maxX);
		float y = Random.Range(minY, maxY);
		float z = Random.Range(minZ, maxZ);

	}
 
	void Update(){
		Instantiate(adProducts, new Vector3(x,y,z), Quaternion.identity);
 	}
}