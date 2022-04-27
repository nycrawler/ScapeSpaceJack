using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treant : Enemy
{
    [SerializeField] Transform parent;
    public override void TakeDamage(int damage)
    {        
        health -= damage;
        //health = health - damage;
        if (health <= 0)
        {
            bossLocation = GameObject.Find("SpawnBossLocation").transform;
            Instantiate(boss, bossLocation.position, Quaternion.identity, parent);
            Die();
        }
    }
}
