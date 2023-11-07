using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    void Update()
    {
        Dead();
    }

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("已造成伤害");
    }

    public virtual void Dead()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
