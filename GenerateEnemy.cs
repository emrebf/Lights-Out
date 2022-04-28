using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 2)
        {
            xPos = Random.Range(1, 10);
            zPos = Random.Range(-1, -2);
            Instantiate(enemy, new Vector3(xPos, 0.398f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(10);
            enemyCount += 1;
        }
    }
}
