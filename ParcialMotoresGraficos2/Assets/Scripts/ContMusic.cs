using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContMusic : MonoBehaviour
{
    public static  bool timer =false;
    public bool timer1;
    // Start is called before the first frame update
    void Start()
    {
        timer = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer1 = timer;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Nota"))
        {
            timer = true;
        }
    }
}
