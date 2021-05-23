using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProcessing : MonoBehaviour
{
    public GameObject pp; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangePointsMat.cont == 2)
        {
            Instantiate(pp);
        }
    }
}
