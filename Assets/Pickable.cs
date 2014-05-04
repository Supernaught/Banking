﻿using UnityEngine;
using System.Collections;

public class Pickable : MonoBehaviour {

	protected string type;

	// Use this for initialization
	public virtual void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "player"){
			Picked();
		}
	}

	public virtual void Picked(){
		Destroy(this.gameObject);
	}
}
