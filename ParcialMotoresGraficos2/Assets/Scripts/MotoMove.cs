using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoMove : MonoBehaviour
{
    Rigidbody rb;
    public float vel;
    public static int contMoto;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, vel);
        
       if(this.transform.position.z > -18)
        {
            vel = 0;

            if (contMoto == 5)
            {
                vel = 1;
                
            }
        }
    }
}
