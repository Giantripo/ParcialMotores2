using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickeable : Interactable
{
    public bool interact;
    public Rigidbody torus;
    public override void Interact()
    {
        base.Interact();
        if (interact)
        {
            Destroy(gameObject);
            ChangePointsMat.cont++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Torus"))
        {
           
            interact = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Torus"))
        {
            interact = false;
        }
    }
}
