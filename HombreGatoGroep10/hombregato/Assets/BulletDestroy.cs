using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {

	// Use this for initialization
	void Update () {

        if (transform.position.y <= -60)
        {
            
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }
	

}
