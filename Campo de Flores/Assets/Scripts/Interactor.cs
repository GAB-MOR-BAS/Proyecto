using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractible
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    void Update()
    {
        //If the player is pressing E
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Shoot a raycast forwards
            Ray raycast = new Ray(InteractorSource.position, InteractorSource.forward);
            //If the raycast touches a collider
            if (Physics.Raycast(raycast, out RaycastHit hitInfo, InteractRange))
            {
                //And if the collider is an "Interactee"
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractible interactObject))
                {
                    //Execute it's interactible script
                    interactObject.Interact();
                }
            }
        }
    }
}
