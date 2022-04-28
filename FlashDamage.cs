
using UnityEngine;

//inspired by this Brackeys tutorial: https://www.youtube.com/watch?v=THnivyG0Mvo&t=3s
public class FlashDamage : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Light damageLight;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(damageLight.transform.position, damageLight.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyNPC enemy = hit.transform.GetComponent<EnemyNPC>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
