﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goback : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        StartCoroutine(Example());
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(2);
        
        SceneManager.LoadScene("Main");
    }
}