using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullit : MonoBehaviour
{
    public Rigidbody2D rb;

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
