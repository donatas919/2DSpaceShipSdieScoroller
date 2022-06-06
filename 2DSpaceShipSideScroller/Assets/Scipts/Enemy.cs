using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ITakeDamage
{
    public float moveSpeed = 5f;
    public float attackInterval;
    
    private Rigidbody2D rb;
    //private Vector2 movement;
    private int health = 1;
    private bool inRange;
    private Player damagable;
    private float nextAttack;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(moveSpeed * -1,0);
    }

    private void Update()
    {
        if (inRange && Time.time > nextAttack)
        {
            damagable.TakeDamage(1);
            nextAttack = Time.time + attackInterval;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
            Destroy(gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        damagable = other.GetComponent<Player>();
        if (damagable != null)
        {
            inRange = true;
        }
    }
}
