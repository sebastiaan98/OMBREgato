using UnityEngine;

public class playershoooot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Update()
    {
     
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    

    void Fire()
    {
        Debug.Log("homo");
       
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

    
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward *100f;

        
    }


}