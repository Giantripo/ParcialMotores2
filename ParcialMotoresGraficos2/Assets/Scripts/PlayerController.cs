using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : ChangeScene
{
    
    public Vector2 sensibility;
    public float rayDistance;
   private new Transform camera;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {

        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");
        if (hor !=0)
        {
            transform.Rotate(Vector3.up * hor * sensibility.x); 
        }
        if (hor != 0)
        {
            transform.Rotate(Vector3.left * ver * sensibility.y);
            //float angle = (camera.localEulerAngles.x - ver * sensibility.y + 360) % 360;
            //if(angle > 180)
            //{
            //    angle -= 360;
            //}
            //angle = Mathf.Clamp(angle, -80, 80);
        }

        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);

        if (Input.GetButtonDown("Interactable"))
        {
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")))
            {
                //me dice el nombre de lo que estoy tocando
                //Debug.Log(hit.transform.name);
                hit.transform.GetComponent<Interactable>().Interact();
            }
        } 
    }
}
