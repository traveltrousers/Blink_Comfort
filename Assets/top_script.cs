using UnityEngine;
using System.Collections;

public class top_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

void Update()
{
	//Use keys to ratchet rotation
	if (Input.GetKeyDown(KeyCode.Q))
		animation.Play("top_lid");

	if (Input.GetKeyDown(KeyCode.E))
		animation.Play("top_lid");
}
}