using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarlos : MotoInstantiator
{
    public float cont2;
    public Rigidbody rb;
    public Transform rotacionTorus;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cont2 = 0.01f;
      rotacionTorus.transform.Rotate(new Vector3(-90, 0, 0));
    }
    private void Update()
    {
        cont2 -= Time.deltaTime;
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //hacer un tag para cada cosa, cada pared para que rebote de forma distinta y despues hacer que los cuadrados se muevan de otra forma
        if (other.gameObject.CompareTag("Wall") && cont2 < 0)
        {
            rb.velocity = new Vector3(velDisparo = velDisparo * -1*Time.deltaTime, 0, 0);
            //velDisparo = velDisparo * -1;

            cont2 = 0.01f;
        }
    }
}
