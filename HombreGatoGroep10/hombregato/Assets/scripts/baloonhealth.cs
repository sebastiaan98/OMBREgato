    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloonhealth : MonoBehaviour {
  
   


	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "balloon")
		{
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "CUBE")
		{
			Destroy(col.gameObject);
		}
	}
}