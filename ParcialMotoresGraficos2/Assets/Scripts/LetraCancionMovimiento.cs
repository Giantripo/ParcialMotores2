using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraCancionMovimiento : MonoBehaviour
{
     Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0,15,0);
    }
}
