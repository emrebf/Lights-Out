using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIEnemyDestroy : MonoBehaviour
{
    public GameObject uiObj;
    public GameObject enemy;

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
            Destroy(enemy);
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(uiObj);
        Destroy(gameObject);
    }
}
