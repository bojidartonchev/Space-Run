﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour {

    private Transform camera;

    // Use this for initialization
    void Start () {
        GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
        GameObject.Find("AnimalGenerator").SetActive(false);
        GameObject.Find("ForestGenerator").SetActive(false);
        camera = GameObject.Find("Main Camera").GetComponent<Transform>();
        GameObject.FindWithTag("BloodScreen").GetComponent<BloodSplat>().enabled = true;

    }
	
	// Update is called once per frame
	void Update () {
        camera.rotation = Quaternion.Lerp(camera.rotation, Quaternion.Euler(333, 252, 62), Time.deltaTime * 2);
    }
}
