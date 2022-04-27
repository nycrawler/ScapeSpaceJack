using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShot : Shot
{
    public override void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player playerHit = hitInfo.GetComponent<Player>();
        if (playerHit != null){
            playerHit.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
