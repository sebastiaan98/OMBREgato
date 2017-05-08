using UnityEngine;
using System.Collections;

public class BaloonMovement : MonoBehaviour
{
    [SerializeField]private float movementSpeed = 1f;
    [SerializeField]private Rigidbody rb;
    [SerializeField]private GameObject objectToDestroy;
    
    void Update()
    {
        if (transform.position.y >= 450)     
        {
            DestroyObject(gameObject);
        }

        Vector3 movement = new Vector3(0f, 4F, 2f);

        rb.velocity = movement * movementSpeed;
    }
}    

    
