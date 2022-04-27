using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public float speed;
    public Rigidbody2D Rb;
    public int damage = 10;
    public float lifeSpan;

    // Start is called before the first frame update
    void Start()
    {
        //Rb.velocity = transform.Translate(-speed, 0, 0);
        //Destroy(gameObject, lifeSpan);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemyHit = hitInfo.GetComponent<Enemy>();
        if (enemyHit != null)
        {
            enemyHit.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

