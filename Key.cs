using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;
    public enum KeyType
    {
        key1,
        key2,
        key3,
        key4
    }

    public KeyType GetKeyType()
    {
        return keyType;
    }
}
