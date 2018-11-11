using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibbonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }
    
    void Update()
    {
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}