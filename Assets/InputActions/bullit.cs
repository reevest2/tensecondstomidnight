using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullit : MonoBehaviour
{
    public Rigidbody2D rb;

    public string enemy = "Enemy";

    void Start()
    {
        Invoke("ApplyTag", .5f);
    }

    public void ApplyTag()
    {
        gameObject.tag = enemy;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (gameObject.tag.Equals("Enemy"))
        {
            if (col.gameObject.tag.Equals("Player"))
            {
                Destroy(col.gameObject);
            }
        }
    }
}
