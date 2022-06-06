using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private ITakeDamage damagable;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        
        ITakeDamage damagable = collision.collider.GetComponent<ITakeDamage>();
        if (damagable != null)
            damagable.TakeDamage(1);
    }
}
