using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractManager : MonoBehaviour
{
    [SerializeField]
    private float interactDistance;

    [SerializeField]
    private Transform cameraPosition;

    [SerializeField]
    private FlashLight flashLight;

    void Start()
    {
        
    }
   
    void Update()
    {
        Ray ray = new Ray(cameraPosition.position, cameraPosition.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            if (Input.GetKeyDown(KeyCode.E)) {
                if (hit.collider.tag == "Battery")
                {
                    flashLight.AddEnergy(1.5f);
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
