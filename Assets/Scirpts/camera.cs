using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime;
using System.Security.Cryptography;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float speed;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {

    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 movePosition = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition,ref velocity, speed);
    }
}
