using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody2D rb;
    private Vector2 moveDirection;
    private Vector2 mousePosition;


    public Camera sceneCamera;
    public float speed = 40f;
    public float speedLimit = 40f;
    public float horizontal;
    public float vertical;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(horizontal, vertical).normalized;

        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);

    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y *speed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = aimAngle;
    }
}
