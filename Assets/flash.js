#pragma strict
	
		function Start () {
		renderer.enabled = false;
	}

	var Blinker : int = 0;
	var Freq : int = 19;
	

		function  Update () {
		
		
				if (Input.GetKeyDown(KeyCode.Z))
			Freq++;
			
					if (Input.GetKeyDown(KeyCode.X))
			Freq--;
		

		if (Blinker == 0)
	{
	renderer.enabled = false;
	}


	Blinker++;
	if (Blinker > Freq)
	{
	Blinker = 0;
	renderer.enabled = true;
	}



}
