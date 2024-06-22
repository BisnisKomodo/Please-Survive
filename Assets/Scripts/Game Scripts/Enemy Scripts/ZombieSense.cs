using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieSense : MonoBehaviour
{
    public bool AwareOfPlayer {get; private set; }
    public Vector2 DirectionToPlayer {get; private set; }
    [SerializeField] private float ZombieSenseDistance;
    private Transform player;
    private void Awake()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }
    void Update()
    {
        Vector2 EnemyToPlayerVector = player.position - transform.position;
        DirectionToPlayer = EnemyToPlayerVector.normalized;

        if (EnemyToPlayerVector.magnitude <= ZombieSenseDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}
