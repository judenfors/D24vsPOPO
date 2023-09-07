using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polisbeteende : MonoBehaviour
{

    Transform target;

    float time = 0;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void LateUpdate()
    {
        Vector3 position = transform.position;
        
        time += Time.deltaTime;
        
        Vector3 direction = target.position - transform.position;
        direction.Normalize();
        transform.position += direction * Time.deltaTime;

    }
}
