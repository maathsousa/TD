﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour {

    private WayPoint[] waypoints;

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
        
	}

    private void OnDrawGizmos(){
        waypoints = FindObjectsOfType<WayPoint>();
    }
}
