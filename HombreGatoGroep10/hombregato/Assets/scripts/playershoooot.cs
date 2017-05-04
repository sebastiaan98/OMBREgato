using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class playershoooot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

	private Valve.VR.InteractionSystem.Player _player;
	void Start () {
		_player = Valve.VR.InteractionSystem.Player.instance;
	}
	void Update () {

		if (_player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			attack ();
		}
	}



    void attack()
    {
        Debug.Log("homo");
       
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

    
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward *100f;

        
    }


}