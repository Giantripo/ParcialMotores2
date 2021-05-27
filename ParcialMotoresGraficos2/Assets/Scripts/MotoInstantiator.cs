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
        float velDisparoRandom = Random.Range(5, 10);
        float velDisparoRandom2 = Random.Range(5, 10);
        cont -= Time.deltaTime;

        if (cont < 0)
        {
            balaImpulso = Instantiate(torusP, disparador.position, Quaternion.identity);
            balaImpulso.AddForce(disparador.right * 100 * velDisparoRandom * Time.deltaTime);
            balaImpulso = Instantiate(notaP, disparador.position, Quaternion.identity);
            balaImpulso.AddForce(disparador.right * 100 * velDisparoRandom2 * Time.deltaTime);
            cont = 3;
        }
    }
}
