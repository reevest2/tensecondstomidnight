using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class shootpoints : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject shootygun;


    public float bulletForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("FirePoint", .5f);
        Rigidbody2D rb = shootygun.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * (bulletForce + 30f) , ForceMode2D.Impulse);
    }

    public void FirePoint()
    {
        GameObject point = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = point.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    public void FirePointNoForce()
    {
        GameObject point = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = shootygun.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
