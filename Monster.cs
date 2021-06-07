using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float StartTime;
    public float minX, maxX;
    public float moveSpeed;
    public int sign = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=StartTime)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime * sign, 0, 0);
           
            if (transform.position.x <= minX||
                transform.position.x >= maxX)
            {
                sign*= -1;
            }
            
        }
    }
}
