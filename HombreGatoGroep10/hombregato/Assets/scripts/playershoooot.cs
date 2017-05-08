using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class playershoooot : MonoBehaviour
{
    [SerializeField]private GameObject bulletPrefab;
    [SerializeField] private  Transform bulletSpawn;

	private Valve.VR.InteractionSystem.Player player;
	void Start () {
        
        player = Valve.VR.InteractionSystem.Player.instance;
	}
	void Update () {
       
        if(Input.GetKeyDown(KeyCode.Space))
            {
            attack();
        }
		if (player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			attack ();
		}
        if (player.leftController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            attack();
        }
    }
    void attack()
    {
       var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward *100f;  
    }
}