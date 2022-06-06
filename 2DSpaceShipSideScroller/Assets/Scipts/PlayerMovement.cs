using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    
    Vector2 movement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * moveSpeed;
        movement.y = Input.GetAxis("Vertical") * moveSpeed;
    }
    
    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //rb.velocity = new Vector2( rb.velocity.x * Time.fixedDeltaTime,rb.velocity.y * Time.fixedDeltaTime);
        Vector3 move= new Vector3(-1*this.movement.y * moveSpeed, this.movement.x * moveSpeed, 0);
        move *= Time.deltaTime;
        transform.Translate(move);
    }
}
