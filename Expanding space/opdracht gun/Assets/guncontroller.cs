using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guncontroller : MonoBehaviour {

	[SerializeField]
    private Gun _gun;
   
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            
            _gun.Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            _gun.Reload();
        }
	}
}
