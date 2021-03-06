﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	public static gameManager instance = null;

	public Rigidbody player;
	public Canvas playerScreen;
	public AudioClip adPlop;

	public GameObject adProductPosOne;
	public GameObject adProductPosTwo;
	public GameObject adVirusPosOne;
	public GameObject adVirusPosTwo;

	private List<GameObject> adList = new List<GameObject>(2);
	public static bool adActive = false;
	private GameObject spawnedAd;
	private AudioSource source;

	void Start(){
		source = GetComponent<AudioSource>();

		adList.Add(adProductPosOne); // }
		adList.Add(adProductPosTwo); // } ALL OF
		adList.Add(adVirusPosOne);	 // } THE ADS
		adList.Add(adVirusPosTwo);	 // }
	}

	void Update(){
		playerController.canJump = !adActive;
		playerController.canDuck = !adActive;
	}

	void OnTriggerEnter(Collider other){
		source.PlayOneShot(adPlop, 1f); // Plays the plop sound when an ad appears on screen.
		source.pitch = Random.Range(0.5f, 1.0f); // Randomizes the plop so it sounds different each time.
	
		spawnedAd = adList[Random.Range(0, adList.Count)];	// Choose a random ad from the list...
		spawnedAd.SetActive(true);	// ...And put it on the player's screen!
		adActive = true; // Warning, ad has entered the building.
	}
}