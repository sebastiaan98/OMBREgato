    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloonhealth : MonoBehaviour {
  
   void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Rballoon")
		{
			Destroy(col.gameObject);
		}
        if (col.gameObject.name == "Lballoon")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "Lballoon(Clone)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "Rballoon(Clone)")
        {
            Destroy(col.gameObject);
        }
    }
}