using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float DamageInflict;

    private void OnCollisionStay2D(Collision2D collision) 
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            var HealthController = collision.gameObject.GetComponent<HealthController>();

            HealthController.TakeDamage(DamageInflict);
        }
    }
}
