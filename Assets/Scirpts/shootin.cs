using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class shootin : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public AudioSource source;
    public AudioClip audioClip;
    //source.PlayOneShot(audioClip);

    
    public float bulletForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("FireProjectile", .5f, 10f);
    }

    // Update is called once per frame
    void FireProjectile()
    {
        for (int i = 0; i < 1; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            source.PlayOneShot(audioClip);
        }
    }
}
