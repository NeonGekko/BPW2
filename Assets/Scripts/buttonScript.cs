﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {

	public GameObject player;
	public GameObject ad;

	public void exitAd(){
		ad.SetActive(false);
		gameManager.adActive = false;
		playerController.canJump = true;

	}
}
