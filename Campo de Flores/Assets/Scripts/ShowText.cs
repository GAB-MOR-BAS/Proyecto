using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowText : MonoBehaviour, IInteractible
{
    public string color;
    public void Interact()
    {
        Debug.Log(color);
    }
}
