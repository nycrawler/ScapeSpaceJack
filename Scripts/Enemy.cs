using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D Rb;
    public GameObject boss;
    public Transform bossLocation;
    //public SpawnEnemies spawn;
    public int health;  
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        //health = health - damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
