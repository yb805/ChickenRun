using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // 따라다닐 타겟 오브젝트 Transform

    private Transform tr; // 카메라 자신의 Transform

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position = new Vector3(target.position.x - 0.1f, tr.position.y, target.position.z - 3f);

        tr.LookAt(target);
    }
}