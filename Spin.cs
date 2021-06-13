using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotSpeed = 80f;


    
    
    void Update ()
    {
        transform.Rotate(new Vector3(0,rotSpeed * Time.deltaTime, 0));
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            

        }
    }
}
