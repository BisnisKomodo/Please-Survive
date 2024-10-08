using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationspeed;
    private Rigidbody2D rb2d;
    private ZombieSense playerAwarenessController;
    private Vector2 targetDirection;
    private float ChangeDirectionCooldown;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerAwarenessController = GetComponent<ZombieSense>();
        targetDirection = transform.up;
    }
    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        HandleRandomTargetDirection();
        HandlePlayerTargeting();
    }

    private void HandleRandomTargetDirection()
    {
        ChangeDirectionCooldown -= Time.deltaTime;
        if (ChangeDirectionCooldown <= 0)
        {
            float anglechange = Random.Range(-90f, 90f);
            Quaternion rotation = Quaternion.AngleAxis(anglechange, transform.forward);
            targetDirection = rotation * targetDirection;

            ChangeDirectionCooldown = Random.Range(1f, 2f);
        }
    }

    private void HandlePlayerTargeting()
    {
        if (playerAwarenessController.AwareOfPlayer)
        {
            targetDirection = playerAwarenessController.DirectionToPlayer;
        }
    }

    private void RotateTowardsTarget()
    {

        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationspeed * Time.deltaTime);

        rb2d.SetRotation(rotation);
    }

    private void SetVelocity()
    {
        
         rb2d.velocity = transform.up * speed;
    }
}

