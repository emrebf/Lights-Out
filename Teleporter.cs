using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget;

    private void OnTriggerEnter(Collider col)
    {
        col.transform.position = teleportTarget.transform.position;
    }
}
