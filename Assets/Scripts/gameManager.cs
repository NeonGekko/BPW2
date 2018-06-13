﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	public GameObject player;
	public GameObject platform;
	public Canvas playerScreen;

	public GameObject adProductPosOne;
	public GameObject adProductPosTwo;

	private List<GameObject> adList = new List<GameObject>(2);
	private GameObject spawnedAd;
	private bool adActive = false;
	private bool canJump = true;

	void Start(){
		adList.Add(adProductPosOne);
		adList.Add(adProductPosTwo);
	}

	void Update(){
		while (adActive == true){
			player.GetComponent<playerController>().canJump = false;
		}
	}

	void OnTriggerEnter(Collider other){
		Instantiate(platform, platform.transform.position + Vector3.forward * 12, platform.transform.rotation);
		Destroy(platform, 10f);
	
		spawnedAd = adList[Random.Range(0, adList.Count)];
		spawnedAd.SetActive(true);
		adActive = true;
	}
}
