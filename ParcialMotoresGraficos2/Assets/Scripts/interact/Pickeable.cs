using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickeable : Interactable
{
    public bool interact;
    public override void Interact()
    {
        base.Interact();
        if (interact)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Nota"))
        {
            interact = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Nota"))
        {
            interact = false;
        }
    }
}
