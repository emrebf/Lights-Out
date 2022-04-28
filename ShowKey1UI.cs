using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKey1UI : MonoBehaviour
{
    public GameObject uiObj;

    private void Start()
    {
        uiObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObj.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(uiObj);
        Destroy(gameObject);
        StopCoroutine("WaitforSec");
    }
}
