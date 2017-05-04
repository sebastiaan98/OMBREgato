using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class playerattack : MonoBehaviour {

private Valve.VR.InteractionSystem.Player _player;

	void Start () {
        _player = Valve.VR.InteractionSystem.Player.instance;
	}
	
	
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Space))
        {

          attack();
        }
		if (_player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			attack ();
		}
	}

    void Shoot()
    {


    }
	public void attack(){
		Debug.Log ("homo");
		}


}
