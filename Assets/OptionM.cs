﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionM : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool isCorrect;

    void OnMouseDown()
    {
        if(isCorrect){
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;
        }
    }
}
