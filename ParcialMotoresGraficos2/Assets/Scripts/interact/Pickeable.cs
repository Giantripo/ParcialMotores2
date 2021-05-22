using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickeable : Interactable
{
   
    public override void Interact()
    {
        base.Interact();
        if (ContMusic.timer)
        {
            Destroy(gameObject);
        }
       
    }
}
