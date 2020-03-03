using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 100;

    public int Damage;

    public int currentHealth;

    
    void Start()
    {
        currentHealth = maxHealth;
    }

    void OnCollisionEnter2D(Collision2D bulletCollision)
    {
        currentHealth -= Damage;
    }
        
    

    void Update()
    {
         if(currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy has died a dog's death");
        }  
    }
}
