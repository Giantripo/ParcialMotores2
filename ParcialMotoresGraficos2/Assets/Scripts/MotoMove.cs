using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

            if (contMoto == 10)
            {
                vel = 1;
                
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        //hacer un tag para cada cosa, cada pared para que rebote de forma distinta y despues hacer que los cuadrados se muevan de otra forma
        if (other.gameObject.CompareTag("Meta"))
        {
            vel = 0;
        }
    }
}
