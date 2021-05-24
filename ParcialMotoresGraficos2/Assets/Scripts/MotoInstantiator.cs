using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoInstantiator : MonoBehaviour
{
    public float velDisparo;
    public Rigidbody torusP;
    public Rigidbody notaP;
    public Transform disparador;
    private Rigidbody balaImpulso;
    public float cont;

    void Start()
    {
        cont = 1;

    }


    void Update()
    {
      
        cont -= Time.deltaTime;

        if (cont < 0)
        {
            balaImpulso = Instantiate(torusP, disparador.position, Quaternion.identity);
            balaImpulso.AddForce(disparador.right * 100 * velDisparo);
            balaImpulso = Instantiate(notaP, disparador.position, Quaternion.identity);
            balaImpulso.AddForce(disparador.right * 100 * velDisparo);
            cont = 3;
        }
    }
}
