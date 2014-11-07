using UnityEngine;
using System.Collections;

public class bottom_script : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		renderer.enabled = true;
	}
	
	void Update()
	{
		//Use keys to ratchet rotation
		if (Input.GetKeyDown(KeyCode.Q))
			animation.Play("bottom_lid");

		if (Input.GetKeyDown(KeyCode.E))
			animation.Play("bottom_lid");

		if (Input.GetKeyDown(KeyCode.W))
			animation.Play("bottom_lid");

		if (Input.GetKeyUp(KeyCode.W))
			animation.Play("bottom_lid");

		if (Input.GetKeyDown(KeyCode.S))
			animation.Play("bottom_lid");

		if (Input.GetKeyUp(KeyCode.S))
			animation.Play("bottom_lid");

	}
}
