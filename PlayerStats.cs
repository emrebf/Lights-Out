using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int healthLevel = 4;
    public int maxHealth;
    public int currentHealth;

    public HealthBar healthbar;

    AnimatorManager animatorManager;

    private void Awake()
    {
        animatorManager = GetComponentInChildren<AnimatorManager>();
    }

    void Start()
    {
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    private int SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLevel * 4;
        return maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            //handle player death
        }

        //animatorManager.PlayTarget
    }
}
