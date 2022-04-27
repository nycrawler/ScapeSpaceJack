using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    [SerializeField] Transform firePoint1;
    [SerializeField] Transform firePoint2;
    [SerializeField] Transform firePoint3;
    [SerializeField] Transform firePoint4;
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] int lastShot = 0;
    [SerializeField] float lastTime = 0;
    [SerializeField] float attackSpeed;


    void Update()
    {
        TimedShots();
    }
    void TimedShots(){
        lastTime = lastTime + Time.deltaTime;
        if (Mathf.Round(lastTime * attackSpeed) != lastShot){
            Shoot();
            lastShot = (int)Mathf.Round(lastTime);
        }
        }
    
    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint1.position, Quaternion.identity);
        Instantiate(projectilePrefab, firePoint2.position, Quaternion.identity);
        Instantiate(projectilePrefab, firePoint3.position, Quaternion.identity);
        Instantiate(projectilePrefab, firePoint4.position, Quaternion.identity);
    }
}
