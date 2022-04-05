using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f * Time.deltaTime, transform.position.z);
        transform.Rotate(new Vector3(1,2,3), Space.Self);
    }
}
