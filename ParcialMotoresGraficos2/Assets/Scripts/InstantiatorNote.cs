using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatorNote : MonoBehaviour
{
    public float velDisparo;
    public Rigidbody torusP;
    public Rigidbody notaP;
    public Transform disparador;
    private Rigidbody balaImpulso;
    public float contTiempo;
    public int contCantidad;
    void Start()
    {

        contCantidad = 0;
        contTiempo = 1;
    }


    void Update()
    {
        float posXGeneracion = Random.Range(-12, 3);
        float posZGeneracion = Random.Range(-20, 12);
        Vector3 posAleatoria = new Vector3(posXGeneracion, 3, posZGeneracion);
        contTiempo -= Time.deltaTime;

        if (contTiempo < 0 &&contCantidad<5)
        {
            
            balaImpulso = Instantiate(torusP, posAleatoria, Quaternion.identity);
            balaImpulso.AddForce(disparador.forward * 100 * velDisparo);
            balaImpulso = Instantiate(notaP, posAleatoria, Quaternion.identity);
            balaImpulso.AddForce(disparador.right * 100 * velDisparo);
            contTiempo = 3;
            contCantidad++;
        }
     
        
    }
}
