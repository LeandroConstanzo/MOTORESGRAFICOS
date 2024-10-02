using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYAI : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target;
 
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed*Time.deltaTime);
    }
}
