using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
        public Transform firePoint;
        public GameObject bulletPrefab;
    
        public float bulletForce = 20f;

        // private float attackInterval;
        // private float nextAttack;
    
        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shooting();
            }
            // {
            //     Shooting();
            //     nextAttack = Time.time + attackInterval;
            // }
        }
         void Shooting()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent <Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
}
