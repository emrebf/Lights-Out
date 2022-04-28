using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public Component doorcolliderhere;
    public GameObject keygone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
        doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
    }
}
