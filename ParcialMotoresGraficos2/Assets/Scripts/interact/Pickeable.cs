using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            MotoMove.contMoto++;

            if (MotoMove.contMoto == 11)
            {
                SceneManager.LoadScene(0);
            }
            if (ChangePointsMat.cont == 5)
            {
                SceneManager.LoadScene(2);
            }
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
