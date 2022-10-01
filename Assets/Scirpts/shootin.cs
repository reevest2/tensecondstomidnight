using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class shootin : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public GameObject spawnObj;
    //public Transform spawnLocations;

    public float bulletForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireProjectile", 10f, 10f);
        Invoke("FirePoint", .5f);
    }

    // Update is called once per frame
    void FireProjectile()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }

    public void FirePoint()
    {
        GameObject point = Instantiate(spawnObj, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = point.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
