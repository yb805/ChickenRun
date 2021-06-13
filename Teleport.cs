using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.name == "Chicken")
        {
            _col.transform.position = Target.position;
        }
    }
}