using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour

{
    [SerializeField] private Key.KeyType keyType;
    public GameObject colliderObj;
    public Animation hingehere;

    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor()
    {
        colliderObj.SetActive(false);
        hingehere.Play();
    }

}
