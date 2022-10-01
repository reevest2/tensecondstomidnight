using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public Rigidbody2D rb;
    public shootin a;

    void Start()
    {
        a=GameObject.FindGameObjectWithTag("Gun").GetComponent<shootin>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (gameObject.tag.Equals("Point"))
        {
            if (col.gameObject.tag.Equals("Player"))
            {
                Destroy(gameObject);

                a.FirePoint();
            }
        }
    }
}