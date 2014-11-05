using UnityEngine;
using System.Collections;

public class bottom_script : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	void Update()
	{
		//Use keys to ratchet rotation
		if (Input.GetKeyDown(KeyCode.Q))
			animation.Play("bottom_lid");
		if (Input.GetKeyDown(KeyCode.E))
			animation.Play("bottom_lid");
	}
}