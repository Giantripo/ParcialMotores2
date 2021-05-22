using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePointsMat : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    public static float cont;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
       
    }
    private void Update()
    {
       

        if (cont == 1)
        {
            rend.sharedMaterial = material[1];
        }
        if (cont == 2)
        {
            rend.sharedMaterial = material[2];
        }
        if (cont ==3)
        {
            rend.sharedMaterial = material[3];
        }
        if (cont ==4)
        {
            rend.sharedMaterial = material[4];
        }
        if (cont ==5)
        {
            rend.sharedMaterial = material[5];
            
        }
     
    }
}
