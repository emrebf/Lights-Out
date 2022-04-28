using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;

    private NavMeshAgent Mob;

    public Animator anim1;

    public float MobDistanceRun = 4.0f;

    private void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
        anim1 = GetComponent<Animator>();
    }


    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;
            Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
            Mob.SetDestination(newPos);
            anim1.SetBool("crawl", true);
        }
        else
        {
            anim1.SetBool("crawl", false);
        }
       
    }

}
