using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public Rigidbody2D rb;
    public shootpoints a;

    public AudioSource source;
    public AudioClip audioClip;

    void Start()
    {
        a=GameObject.FindGameObjectWithTag("pointgun").GetComponent<shootpoints>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (gameObject.tag.Equals("Point"))
        {
            if (col.gameObject.tag.Equals("Player"))
            {
                Destroy(gameObject);
                Score.scoreAmount +=1;
                source.PlayOneShot(audioClip);
                a.FirePointNoForce();
            }
        }
    }
}